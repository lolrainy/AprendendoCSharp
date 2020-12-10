using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            {
                valorInvestido *= 1.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine(
                       "após " + contadorMes +
                       " mês, você terá R$ " + valorInvestido);
                }
                else {             
                    Console.WriteLine(
                        "após " + contadorMes +
                        " meses, você terá R$ " + valorInvestido);
                    }

            }
            Console.ReadLine();
        }
    }
}
