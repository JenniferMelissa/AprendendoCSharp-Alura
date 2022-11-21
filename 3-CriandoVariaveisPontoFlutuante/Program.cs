using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variaveis Ponto FLuuante!");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            //quando lidamos com numeros inteiros na equação, ao estar declarado o tipo double, perdemos o que 
            //vem depois da casa decimal

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            //transformando a idade em double, ela vai retornar as casas decimais 
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
