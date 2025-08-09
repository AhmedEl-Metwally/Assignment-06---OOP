using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public abstract class Discount
    {
        public string Name { get; protected set; } = string.Empty;
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
