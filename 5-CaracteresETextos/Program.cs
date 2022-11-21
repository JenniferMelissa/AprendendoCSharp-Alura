using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Textos!");

            //Character - usa aspas simples '', pois nao é um texto e sim um caracter, inteiro nao cabe no char
            //cabe apenas 1 bits, não pode ser vazia, tem que ter um caracter dentro, o espaço é um caracter --> ' '
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            //String - tipo representado para texto
            //pode ser vazio --> ""
            string titulo = "Alura Cursos de Tecnologia " + 2022;
            Console.WriteLine(titulo);


            string vazia = "";

            string cursosProgramação = " - .Net" +
                " - Java" + " - Javascript";
            Console.WriteLine(cursosProgramação);

            //Ao utilizar o "@" o compilador ele considera tudo entre os pas de aspas como texto, inclusive os espaços 
            string cursosProgramação2 = 
               @"- .Net
                - Java 
                - Javascript";
            Console.WriteLine(cursosProgramação2);
            

            Console.ReadLine();
        }
    }
}
