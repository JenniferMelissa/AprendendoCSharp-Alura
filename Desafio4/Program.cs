using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( coluna >= linha )
                    {
                        break;
                    }
                    Console.Write("???");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
