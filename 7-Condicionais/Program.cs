using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18, mas esta acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 e nao esta acompanhado");
                }

            }
            Console.ReadLine();
        }
    }
}
