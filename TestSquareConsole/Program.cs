using System;
using TestSquareLibrary;

namespace TestSquareConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle(11);
            Console.WriteLine(circ.Square());

            Triangle tr = new Triangle(3, 4, 5);
            Console.WriteLine(tr.Square());
            Console.WriteLine(tr.CheckingTheTriangle());

            Triangle triang = new Triangle(9, 9, 6);
            Console.WriteLine(triang.Square());
            Console.WriteLine(triang.CheckingTheTriangle());
        }
    }
}
