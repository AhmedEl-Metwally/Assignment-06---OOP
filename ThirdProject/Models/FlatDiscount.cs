using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public class FlatDiscount : Discount
    {
        private decimal _flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            _flatAmount = flatAmount;
            Name = $"Flat Discount of {_flatAmount:C} ";
        }

        public override decimal CalculateDiscount(decimal price, int quantity) => _flatAmount *Math.Min(quantity, 1);

    }
}
