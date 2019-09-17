
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_teste
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("testando condicionais");

            /*testando booleana */

            int idade = 16;
            int quantiPessoas = 3;

            if (idade >= 18 || quantiPessoas >= 2)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
                Console.ReadLine();
            }

            /**/

            int idadeTeste = 16;
            int quantiPessoasTeste = 3;
            bool acompanhado = quantiPessoasTeste >= 2;

            if (idadeTeste >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Não foi possivel liberar sua entrada");
            }


            Console.ReadLine();


        }
    }
}
