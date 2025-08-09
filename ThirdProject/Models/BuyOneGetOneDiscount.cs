using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount() =>Name = "Buy One Get One Discount (50% off second item) ";

        public override decimal CalculateDiscount(decimal price, int quantity) =>  quantity > 1 ? (price / 2) * (quantity / 2) : 0;

    }
}
