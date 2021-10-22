using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSquareLibrary
{
  public class Triangle : Figure
    {
        double a, b, c, perimetr, square;
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;

            if (a <= 0 | b <= 0 | c <= 0)
            {
                throw new Exception("Стороны треугольника не могут быть меньше либо равны нулю");
            }
        }
        public override double Square()
        {
            perimetr = (a + b + c) / 2;
           return square = Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
        public string CheckingTheTriangle()
        {
            // Проверка является ли треугольник прямоугольным
            return a * a == b * b + c * c | b * b == a * a + c * c | c * c == a * a + b * b ?  "Треугольник равнобедренный" : "Треугольник не равнобедренный";       
        }
    }
}
