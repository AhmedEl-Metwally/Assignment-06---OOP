using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject.Models
{
    public class GuestUser : User
    {
        public override Discount GetDiscount() => null;
      
    }
}
