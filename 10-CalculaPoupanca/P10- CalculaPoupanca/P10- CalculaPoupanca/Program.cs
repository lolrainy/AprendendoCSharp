using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá " + valorInvestido);
                    contadorMes += 1;
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá " + valorInvestido);
                    contadorMes += 1;
                }
                
                //contadorMes = contadorMes + 1;
            }

            Console.ReadLine();
        }
    }
}