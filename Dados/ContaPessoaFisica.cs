namespace dados{
    public class ContaPessoaFisica : Conta
    {
        public string NomeCliente { get; set; }
        public string DataNascimento { get; set; }
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.10);
            return this.Saldo;
        }
        public override double Depositar(double valor){
            System.Console.WriteLine("Efetuou um depósito no valor de R$"+valor);
            this.Saldo += valor + 0.01;
            return this.Saldo;
        }
    }
}