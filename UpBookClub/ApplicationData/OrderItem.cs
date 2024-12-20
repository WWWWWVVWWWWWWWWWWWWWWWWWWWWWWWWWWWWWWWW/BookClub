using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpBookClub.ApplicationData
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * (Product.Discount.HasValue
                                                 ? Product.Price * (1 - Product.Discount.Value / 100)
                                                 : Product.Price);
    }
}
