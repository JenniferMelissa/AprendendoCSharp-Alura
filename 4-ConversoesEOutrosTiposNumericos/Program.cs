using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4!");

            double salario;
            salario = 1500.50;

            //CASTING - Mostra para o compilador que voce quer fazer a conversao do tipo double
            //para o tipo int mesmo perdendo a casa decimal, precisao do numero.
            int salarioInteiro;
            //INT - suporta apenas 32 bits
            salarioInteiro = (int)salario;



            Console.WriteLine(salarioInteiro);


            //long - é um tipo de variavel inteiro que suporta 64 bits mas ocupa mais espaço na memória, por isso 
            //é menos usado
            long idade;
            idade = 1333333333333;
            Console.WriteLine(idade);

            //short - é um tipo de variavel que armazena uma quantidade de  valor muito menor
            //ocupa 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            //AO CRIAR UMA VARIAVEL JA ATRIBUA O VALOR A ELA
            //o tipo float é convertido implicitamente em double.
            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
