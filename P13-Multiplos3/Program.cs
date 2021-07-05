using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("projeto 14");
            int multiplosTres;

            for(multiplosTres=1;multiplosTres<=100;multiplosTres++)
            {
                if(multiplosTres % 3 == 0)
                {
                    Console.WriteLine(multiplosTres);
                }
            }
            Console.ReadLine();
        }
    }
}
