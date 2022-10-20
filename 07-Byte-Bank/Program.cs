using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Eliton";
            cliente.CPF = "123.31.123.122";
            cliente.Profissao = "Desenvolvedor";
                      
            conta.Saldo = -10;
            conta.Titular = cliente;
            conta.Depositar(100);
            conta.Sacar(50);
            
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.CPF);
            Console.ReadLine();


        }
    }
}
