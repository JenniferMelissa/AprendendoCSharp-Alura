using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Atribuições de Variaveis!");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;


            // Ao fazer isso, a variavel idadeGustavo vai copiar o valor da variavel idade(32) e vai armazena-lo
            //mesmo que altere a variavel idade(como no exemplo a cima), o valor da variavel idadeGustavo não é alterada
            //pois está mexendo apenas no idade e nao no idadeGustavo





            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
