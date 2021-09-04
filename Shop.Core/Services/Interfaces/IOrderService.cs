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
        int AddOrder(string userName, int prodcutId);

        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string userName, int orderId);
        
        bool FinalyOrder(string userName, int orderId);
        
    }
}
