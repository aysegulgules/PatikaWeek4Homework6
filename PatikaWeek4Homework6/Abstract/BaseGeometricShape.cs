using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework6.Abstract
{
    public class BaseGeometricShape
    {
        //Property'ler tanımlanıyor
        public int Width { get; set; }
        public int Height { get; set; }
        
        //Bu classı miras alan tüm sınıflar için bu metod içeriği değiştirilebilinir
        public  virtual double CalculateArea() 
        {
            return Width * Height;
        }
    }
}
