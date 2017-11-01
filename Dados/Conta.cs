namespace dados{
    public class Conta{
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public double Saldo { get; set; }

        public void Sacar(double valor){
            this.Saldo -= valor;
        }
        
        public void Depositar(double valor){
            this.Saldo += valor;
        }
        
        public double MeuSaldo(){
            return this.Saldo;
        }
    }
}