using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public abstract class User
    {
        public string Name { get; set; } = string.Empty;
        public abstract Discount GetDiscount();
    }
}
