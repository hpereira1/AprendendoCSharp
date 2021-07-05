using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;
           
            int salarioEmInteiro= (int)salario;
            Console.WriteLine(salarioEmInteiro);
           
            // 64 bits para variaveis >bilhao
            long idade = 130000000000;
            Console.WriteLine(idade);
            
            short quantidadeProdutos = 15000; //var 16 bits ate 16000
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);
            
            Console.ReadLine();
        }
    }
}
