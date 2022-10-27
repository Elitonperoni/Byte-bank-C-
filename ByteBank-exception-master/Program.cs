using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(7485, 14312);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);

            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Não é possível dividir um número por 0");
            }
            catch (NullReferenceException)
            {
                Console.Write("Aconteceu um erro!");
            }

            Console.ReadLine();
        }

        private static void Metodo()
        {
           
            TestaDivisao(10);                                
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if (resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por 0");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }           
        }

        private static int Dividir(int numero, int divisor)
        {                      
            return numero / divisor;
        }

        /*
         Dividir <-
        TestaDivisao
        Metodo
        Main
         */

    }
}
