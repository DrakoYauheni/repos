using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Action<int,int> op;
            op = Multiply;
            Operation(20, 2, op);
            op = Delenie;
            Operation(50, 2, op);

            Console.ReadLine();
        }       

        static void Operation(int x, int y, Action<int, int> op)
        {
            op(x, y);
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Delenie(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
