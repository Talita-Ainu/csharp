using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario > 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Seu desconto será de 7.5% no IR");
            }
            else if (salario > 2800.0 && salario <= 3751.0)
                {
                    Console.WriteLine("Seu desconto será de 15% no IR");
                }
                else if (salario > 3751.01 && salario  <= 4664.0)
                {
                    Console.WriteLine("Seu desconto será de 22.5% no IR");
                }
                
            Console.ReadLine();
        }
    }
}
