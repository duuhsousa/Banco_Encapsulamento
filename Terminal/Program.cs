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
            conta.Depositar(250);
            Console.WriteLine(conta.MeuSaldo());
            Console.Write("Digite o CPF: ");
            string documento = Console.ReadLine();
            validacao.ValidarCPF(documento);
            

        }
    }
}
