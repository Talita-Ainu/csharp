using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais")
            int idade = 20;
            int quantiPessoas = 3;
            bool acompanhado;


            if (quantiPessoas >= 2)
            {
                acompanhado = true;
            }

            else
            {
                acompanhado = false;
            }
            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }
        }
    }
}
