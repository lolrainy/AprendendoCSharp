using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        char letra = 'a';
        Console.WriteLine(letra);

        char valor = (char)65;
        Console.WriteLine(valor);

        valor = (char)(valor + 1);
        Console.WriteLine(valor);

        string palavra = "Cursos online de tecnologia da Alura ";
        Console.WriteLine(palavra);

        palavra = palavra  + 2020;
        Console.WriteLine(palavra);

        Console.WriteLine("Aperte enter para fechar a aplicação");
        Console.ReadLine();
    }
}
