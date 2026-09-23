using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CalcularAreaCirculo(double radio)
            {
                return 3.1415 * radio * radio;
                
            }
            Console.WriteLine(CalcularAreaCirculo(6));
        }
    }
}
