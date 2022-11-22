using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio6
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Agora crie uma nova classe, escreva um for que inicie uma 
            //variável n(número atual) como 1 e fatorial(resultado total) 
            //como 1.Faça seu laço entre 1 a 10 e calcule o resultado!

            int fatorial = 1;
            for(int n = 1; n  < 11; n++)
            {
                    fatorial *= n;
                Console.WriteLine("Fatorial de " + n + " = " + fatorial);
            }
            Console.ReadLine();

        }
    }
}
