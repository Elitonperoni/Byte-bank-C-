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
            ContaCorrente conta = new ContaCorrente(0602, 86712540);

            Console.WriteLine("n° de contas: " + ContaCorrente.ObterTotalDeContasCriadas());
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);            

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);

            Console.WriteLine("n° de contas: " + ContaCorrente.ObterTotalDeContasCriadas());


            Console.ReadLine();


        }
    }
}
