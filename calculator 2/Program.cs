using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To perform simple calculator operations");
            Console.WriteLine();
            Console.WriteLine("Enter a value:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            bool op = true;
            double result = 0;
            while (op == true)
            {
                Console.WriteLine("Enter operations + - * / =");
                char o = Console.ReadLine()[0];

              
                if (o == '=')
                {
                    op = false;
                    break;
                }
                Console.WriteLine("Enter the next value: ");
                double n2=Convert.ToDouble(Console.ReadLine());
                
                if (o == '+')
                    result = (n1 + n2);

                else if (o == '-')
                    result = (n1 - n2);

                else if ( o == '*')
                    result = (n1 * n2);

                else if (o == '/')
                {
                    if (n2 == 0)
                        Console.WriteLine("undefined");
                    else
                        result = (n1 / n2);
                }
                n1 = result;
                

            }
            Console.WriteLine("output:" + n1);
        }

    }

}
