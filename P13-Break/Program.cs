using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13!");


            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********

            //ESCREVENDO ASTERISCOS(*) COM O BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                    //Break - Quebra o laço de repetição, apenas no laço de repetição que ele se encontra
                }

                Console.WriteLine();
            }





            //UMA FORMA DIFERENTE DE FAZER O DESENHO DE ASTERISCOS
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                  
                    //Break - Quebra o laço de repetição, apenas no laço de repetição que ele se encontra
                }

                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
