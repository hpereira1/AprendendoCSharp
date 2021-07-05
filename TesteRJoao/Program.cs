using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRJoao
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("pode deduzir 142 reais");
                Console.WriteLine("Sua aliquota é de 7%");
            }
            else if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("sua aliquota é de 15%");
                Console.WriteLine("pode deduzir ate 350 reais");

            }
            else if (salario >= 3751.01 && salario <= 4663.0)
            {
                Console.WriteLine("sua aliquota é de 22.5%");
                Console.WriteLine("pode deduzir ate 636 reais");
            }
            Console.ReadLine();
        }
    }
}
