using System;

namespace dados{
    public class ContaPessoaJuridica : Conta
    {
        Empresa empresa {get;set;}

        public override double Sacar(double Valor){
            this.Saldo += Valor + 2;

            return this.Saldo;
        }

        public void CadastrarConta(string Numero, string Agencia, double Saldo, string RazaoSocial, DateTime DataAbertura, string CNPJ){

        }
    }
}