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
            string program_name = "Modul02 - Примери";
            string program_version = "1.0";



            //За програмата
            Console.WriteLine(program_name);
            Console.WriteLine("Версия: " + program_version + "\n\n");
            Console.WriteLine();

            //Събиране на числа
            a = 10;
            b = 5;
            sum = a + b;


            //Писане в конзолата
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write(" = ");
            Console.WriteLine(sum);


            //Допълнителни оператори
            Console.WriteLine("\nИзползване на +=");
            a += b; 
            Console.Write(a);

            Console.WriteLine("\nИзползване на -=");
            a -= b;
            Console.Write(a);

            Console.WriteLine("\nИзползване на *=");
            a *= b;
            Console.Write(a);

            Console.WriteLine("\nИзползване на ++");
            a++;
            Console.Write(a);
            Console.WriteLine();
            Console.WriteLine ("Стандартно деление: " + (7 / 4).ToString()); // =1
            Console.WriteLine ("Остатък от стандартно деление: " + (7 % 4).ToString()); //=3
            Console.WriteLine(program_name);

            Console.ReadKey();
          
        }
    }
}
