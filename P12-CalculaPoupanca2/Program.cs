using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Laço de Repetição For");

            ////Contador          
            //int contadorMes = 1;

            ////Condição(Expressao Boleana que define se o laço vai ser executado ou não) 
            //contadorMes <= 12;

            ////Incrementador(incrementa o contador)
            //contadorMes = contadorMes + 1;



            double valorInvestido = 1000;



            //For - mesma ideia do while
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.0036;
                //OU
                //valorInvestido = valorInvestido * 1.0036;
                //OU
                valorInvestido *=  1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
