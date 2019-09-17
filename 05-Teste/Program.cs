using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CaracterETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';

            Console.WriteLine(letra);
            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

            char valor = (char)65; //Converter um numero em um valor da tabela ASCII
            Console.WriteLine(valor);
            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

            valor = (char)(valor + 1);
            Console.WriteLine(valor);
            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

            string palavra = "DKP crescendo com você";
            Console.WriteLine(palavra);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

            /*CONCATENANDO STRINGS*/

            string meuNome = "Talita";
            string meuSobrenome = "Nascimento";
            string nomeCompleto;

            nomeCompleto = meuNome + meuSobrenome;
            Console.WriteLine(nomeCompleto);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();

            /*Lembrando: String aspas duplas e char aspas simples*/

        }
    }
}
