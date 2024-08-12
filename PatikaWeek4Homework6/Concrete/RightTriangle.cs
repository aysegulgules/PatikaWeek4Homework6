using PatikaWeek4Homework6.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework6.Concrete
{
    //Dik üçgen classı
    public class RightTriangle:BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return (Width * Height)/2;
        }
    }
}
