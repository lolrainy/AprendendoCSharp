using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 20;
        int quantidadePessoas = 3;

        if (idade >= 18)
        {
            Console.WriteLine("A idade da pessoa em questão é maior do que 18 anos.");
        }

        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.Write("Você esta acompanhado. Pode entrar.");
            }
            else
            {
                Console.WriteLine("O indivíduo tem menos de 18 anos.");
            }
        }
    }
}