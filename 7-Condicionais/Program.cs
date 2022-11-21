using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    public class Program
    {
        //Atalho para deixar o codigo organizado - Ctrl K + Ctrl D
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais!");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18, mas está acompanhado. Pode Entrar!");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18. Não pode entrar!");
                }

            }



            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
