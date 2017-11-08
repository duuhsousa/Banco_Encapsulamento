using System;
using dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do{
                Console.WriteLine("Digite a opção");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("9 - Sair");
                
                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    {
                        CadastrarConta();
                    }break;
                    case "2":
                    case "3":
                    case "9":
                    default:break;
                }
            }while(opcao != "9");


        }

        static void CadastrarConta(){
            Validacao validacao = new Validacao();
            int opvalid = 0;

            Console.WriteLine("Digite a Razao Social: ");
            string razaosocial = Console.ReadLine();

            Console.WriteLine("Digite a Data de Abertura: ");
            string dataabertura = Console.ReadLine();

            Console.WriteLine("Digite seu CNPJ: ");
            string cnpj;
            do{
                cnpj = Console.ReadLine();
                opvalid = validacao.ValidarCNPJ(cnpj);
            }while (opvalid == 0);

            Console.WriteLine("Digite seu agencia: ");
            string agencia = Console.ReadLine();

            Console.WriteLine("Digite seu número de conta: ");
            string numeroconta = Console.ReadLine();

            Console.WriteLine("Digite a Conta: ");
            string conta = Console.ReadLine();

            Console.WriteLine("Digite o Saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            ContaPessoaJuridica contaju = new ContaPessoaJuridica();
            contaju.CadastrarConta(numeroconta,agencia,saldo,razaosocial,Convert.ToDateTime(dataabertura),cnpj);

        }
    }
}
