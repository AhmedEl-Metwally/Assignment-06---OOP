using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Interface
{
    public interface IPoint3D : IComparable , IComparable<IPoint3D>    
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}
