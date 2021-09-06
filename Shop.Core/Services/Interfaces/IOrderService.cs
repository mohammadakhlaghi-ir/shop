using Shop.Core.DTOs.Order;
using Shop.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services.Interfaces
{
    public interface IOrderService
    {
        #region Order
        int AddOrder(string userName, int prodcutId);
        List<Order> GetAllOrders();
        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string userName, int orderId);
        Order GetOrderById(int orderId);
        bool FinalyOrder(string userName, int orderId);
        List<Order> GetUserOrders(string userName);

        void UpdateOrder(Order order);
        bool IsUserInProduct(string userName, int productId);
        OrderForAdminViewModel GetOrders(int pageId = 1, string filterOrderId = "", string filterUserName = "");
        #endregion
        #region DisCount

        DiscountUseType UseDiscount(int orderId, string code);
        void AddDiscount(Discount discount);

        List<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        void DeleteDiscount(Discount discount);
        bool IsExistCode(string code);
        #endregion

    }
}
