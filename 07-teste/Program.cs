using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TestandoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 16;
            int qntPessoas = 3;

            /*Primeira condição idade*/
            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem-vindo");
            }
            /*Segunda condição para acompanhamento*/
            else
            {
                if (qntPessoas >= 2)
                {
                    Console.WriteLine("Voce esta acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }

            }

            Console.ReadLine();
        }
    }
}
