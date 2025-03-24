using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Helpers
{
    public class ProcessOrderHelper
    {
        public static List<OrderProcessing> CreateOrderProcessingList(List<CartItem> cartItems, string? transNo, int cashierId, string? notes, string? orderType)
        {
            return cartItems.Select(cartItem => new OrderProcessing
            {
                TransNo = transNo,
                ProductId = cartItem.productId,
                CashierId = cashierId,
                Quantity = cartItem.Quantity,
                Price = cartItem.productPrice,
                TotalPrice = cartItem.Quantity * cartItem.productPrice,
                Notes = notes,
                OrderType = orderType
            }).ToList();
        }
    }
}
