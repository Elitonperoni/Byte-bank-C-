﻿using ByteBank_exception_master;
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

            try
            {
                ContaCorrente conta = new ContaCorrente(5025, 52665);
                ContaCorrente conta2= new ContaCorrente(5025, 52665);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);

                //conta.Sacar(500);
                conta.Transferir(500, conta2);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteExeption");
            }
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção Interna");m

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }

            Metodo();
            Console.ReadLine();
        }

        private static void Metodo()
        {
           
            TestaDivisao(10);                                
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
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
            

        }

        /*
         Dividir <-
        TestaDivisao
        Metodo
        Main
         */

    }
}
