using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo !");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            //pode tirar o "{}" do else quando tem apenas uma instrução dentro, apenas UMA LINHA,s e tiver oura linha não vai fazer parte do else mais
            else
            {
                mensagemAdicional = ("Jpão não está acompanhado!");
            }
                 
            
        

            
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
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
