namespace PaymentSystem
{
    public class Debito
    {
        private int numeroBanco;
        private int numeroAgencia;
        private int numeroConta;
        private string titular ContaCorrente;
        protected double saldo;
        public DebitoContaCorrente
        (int numeroBanco, numeroAgencia, numeroConta, string titular)
        {
        this. numeroBanco = numeroBanco;
        this. numeroAgencia = numeroAgencia;
        this. numeroConta = numeroConta;
        this.titular = titular;
        }
        public boolean debitar(double valor) {
        this.saldo += valor
        return true;
        public double get Saldo(){
        return this.saldo;
        }
    }
}
