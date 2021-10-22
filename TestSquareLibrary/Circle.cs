using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSquareLibrary
{
   public class Circle : Figure
    {
        double circleRadius;
        
        public Circle(double radius)
        {
            circleRadius = radius;
            if (radius <= 0) 
                throw new Exception("Радиус не может быть равен нулю или меньше нуля");
        }
        public override double Square()
        {
           return circleRadius = (circleRadius * circleRadius) * Math.PI;
        }
        
    }         
}
