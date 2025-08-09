using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public class PercentageDiscount : Discount
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
            Name = $"{percentage} % Percentage Discount ";
        }

        public override decimal CalculateDiscount(decimal price, int quantity) => price * quantity * (_percentage / 100);
      
    }
}
