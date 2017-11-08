using System;
using dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Validacao validacao = new Validacao();
            ContaPessoaFisica contapf = new ContaPessoaFisica();

            //conta.Depositar(250);
            contapf.Depositar(250);
            //Console.WriteLine(conta.MeuSaldo());
            Console.WriteLine(contapf.MeuSaldo());
            //conta.Sacar(50);
            contapf.Sacar(50);
            //Console.WriteLine("Meu saldo é CONTA"+conta.MeuSaldo().ToString());
            Console.WriteLine("Meu saldo é PF"+contapf.MeuSaldo().ToString());    
        }
    }
}
