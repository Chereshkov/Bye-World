using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sch = new Random().Next(1, 101);

            int a;

            int br = 0;

            do
            {
                a = int.Parse(Console.ReadLine());

                if (a > sch)
                {
                    Console.WriteLine("Chisloto e po-malko ot {0}", a);
                }

                else if (a < sch)
                {
                    Console.WriteLine("Chisloto e po-golqmo ot {0}", a);
                }

                br++;

            } while (a != sch);

            Console.WriteLine("Vie poznahte ot {0} opit", br);

            Console.ReadLine();

        }
    }
}
