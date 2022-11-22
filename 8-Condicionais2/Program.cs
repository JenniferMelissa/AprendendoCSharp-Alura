using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2!");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;

            //Variavel Booleana - True ou False
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            //Operador Lógico
            // || --> OU ou OR
            //&& --> E 
            // == --> compara valores
            // = --> atribuindo valores
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");

            }



            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
