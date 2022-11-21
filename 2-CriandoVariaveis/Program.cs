using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variaveis!");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);

            //O C# faz primeiro a multiplicação e divisão, depois soma e subtração
            idade = 10 * 5 + 2;
            Console.WriteLine(idade);

            //parenteses tem mais preferencia do que multiplicação e divisão
            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é "+ idade + "!"); // Concatenação
            //Console.Write - Apenas escreve, não pula linha
            Console.Write(idade); 


            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
