using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18 && quantidadePessoas >= 2)
        {
            Console.WriteLine("João possui mais de 18 anos de idade ou esta acompanhado. Pode entrar.");
        }
        else
        {
            Console.WriteLine("João não pode entrar");
        }

        Console.ReadLine();
    }
}
