using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            for(int i =0; i<10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("The side: {0} , the area {1}", squares[i].GetSide, squares[i].GetArea);
                Console.ReadKey();
            }
        }
    }
}
