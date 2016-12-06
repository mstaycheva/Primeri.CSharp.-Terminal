using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниране на променливи
            int a = 5, b = 0;

            //Въвеждане на входни парамери

            Console.Write("Моля въведете а: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Печат на резултат
            Console.WriteLine("Резултатът а + б е " + (a + b).ToString () + "\n\n\n" );

            Console.ReadKey();
        }
    }
}
