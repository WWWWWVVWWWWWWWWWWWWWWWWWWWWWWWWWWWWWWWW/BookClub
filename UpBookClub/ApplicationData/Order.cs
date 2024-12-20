using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpBookClub.ApplicationData
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public string PickupPoint { get; set; }
        public decimal TotalPrice => Items.Sum(item => item.TotalPrice);
        public decimal TotalDiscount => Items.Sum(item =>
            item.Product.Discount.HasValue ? item.Quantity * item.Product.Price * item.Product.Discount.Value / 100 : 0);

        public string PickupCode { get; set; } // 3-значный код
    }
}
