using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança! ");


            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                //0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                
                //---->>>INCREMENTANDO VARIAVEL
                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }



            //0.36% = 0.0036
            
            Console.ReadLine();
        }
    }
}
