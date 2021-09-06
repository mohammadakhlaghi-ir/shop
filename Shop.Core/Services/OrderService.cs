using Microsoft.EntityFrameworkCore;
using Shop.Core.DTOs.Order;
using Shop.Core.Services.Interfaces;
using Shop.DataLayer.Context;
using Shop.DataLayer.Entities;
using Shop.DataLayer.Entities.Product;
using Shop.DataLayer.Entities.User;
using Shop.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Core.Services
{
    public class OrderService : IOrderService
    {
        private ShopContext _context;
        private IUserService _userService;

        public OrderService(ShopContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public int AddOrder(string userName, int productId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var product = _context.Products.Find(productId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = product.ProductPrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            ProductId = productId,
                           
                            Price = product.ProductPrice
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == productId);
                if (detail != null)
                {
                    
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        
                        ProductId = productId,
                        Price = product.ProductPrice,
                    };
                    _context.OrderDetails.Add(detail);
                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }


            return order.OrderId;

        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public Order GetOrderForUserPanel(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public bool FinalyOrder(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            var order = _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == userId);

            if (order == null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(userName) >= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شما #" + order.OrderId,
                    UserId = userId,
                    TypeId = 2
                });
                _context.Orders.Update(order);

                foreach (var detail in order.OrderDetails)
                {
                    _context.UserProducts.Add(new UserProduct()
                    {
                        ProductId = detail.ProductId,
                        UserId = userId
                    });
                }

                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Order> GetUserOrders(string userName)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.Orders.Where(o => o.UserId == userId).ToList();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public DiscountUseType UseDiscount(int orderId, string code)
        {
            var discount = _context.Discounts.SingleOrDefault(d => d.DiscountCode == code);

            if (discount == null)
                return DiscountUseType.NotFound;

            if (discount.StartDate != null && discount.StartDate > DateTime.Now)
                return DiscountUseType.ExpierDate;

            if (discount.EndDate != null && discount.EndDate < DateTime.Now)
                return DiscountUseType.ExpierDate;


            if (discount.UsableCount != null && discount.UsableCount < 1)
                return DiscountUseType.Finished;

            var order = GetOrderById(orderId);

            if (_context.UserDiscountCodes.Any(d => d.UserId == order.UserId && d.DiscountId == discount.DiscountId))
                return DiscountUseType.UserUsed;

            int percent = (order.OrderSum * discount.DiscountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _context.Discounts.Update(discount);
            _context.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });
            _context.SaveChanges();



            return DiscountUseType.Success;
        }


        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);

        }

        public void AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();

        }

        public List<Discount> GetAllDiscounts()
        {
            return _context.Discounts.ToList();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.Find(discountId);
        }

        public void UpdateDiscount(Discount discount)
        {
            _context.Discounts.Update(discount);
            _context.SaveChanges();
        }

        public void DeleteDiscount(Discount discount)
        {
            _context.Discounts.Remove(_context.Discounts.Find(discount.DiscountId));

            _context.SaveChanges();
        }

        public bool IsExistCode(string code)
        {
            return _context.Discounts.Any(d => d.DiscountCode == code);
        }

        public bool IsUserInProduct(string userName, int productId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.UserProducts.Any(c => c.UserId == userId && c.ProductId == productId);

        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public OrderForAdminViewModel GetOrders(int pageId = 1, string filterOrderId = "", string filterUserName = "")
        {
            IQueryable<Order> result = _context.Orders.Include(o => o.User);
            
            if (!string.IsNullOrEmpty(filterOrderId))
            {
                result = result.Where(o => o.OrderId.ToString().Contains(filterOrderId));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.User.UserName.Contains(filterUserName));
            }


            // Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;


            OrderForAdminViewModel list = new OrderForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Orders = result.OrderBy(u => u.CreateDate).Skip(skip).Take(take).ToList();

            return list;
        }
    }

}
