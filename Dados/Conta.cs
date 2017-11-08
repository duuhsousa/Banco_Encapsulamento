namespace dados{
    public class Conta{
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public double Saldo { get; protected set; }

        public virtual double Sacar(double valor){
            this.Saldo -= valor;
            return this.Saldo;
        }
        
        public virtual double Depositar(double valor){
            this.Saldo += valor;
            return this.Saldo;
        }
        
        public double MeuSaldo(){
            return this.Saldo;
        }
    }
}