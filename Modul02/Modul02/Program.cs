using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниране на променливи
            int a = 0, b = 0;
            int sum = 0;

            //Събиране на числа
            a = 55;
            b = 10;
            sum = a + b;


            //Писане в конзолата
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write(" = ");
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
