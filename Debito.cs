namespace PaymentSystem
{
    public class Debito : Cartao
    {
       private float saldo = 0.0f;

       public float ConsultarSaldo()
       {
            return saldo;
       }

       public void AtualizarSaldo(float valor)
       {
            saldo += valor;
       }

       public override void Pagar()
       {
          Console.WriteLine($"");
          Console.WriteLine($"Obrigado por optar por pagar com cartão de debito");
          Thread.Sleep(3500);
          Console.WriteLine($"O seu saldo é de {saldo}");
          
          Console.WriteLine($"Digite (S) para efetuar o pagamento com a forma de débito e (N) para cancelar!");
          char resp = char.Parse(Console.ReadLine().ToLower());
          
          if (resp == 's')
          {
               Console.WriteLine($"Pagamento efetuado com sucesso!");
               
          }
          else
          {
               Console.WriteLine($"Forma de pagamento em débito cancelado!");

          }

          
          
          
       }
       

       
       
       
       
       
       
       
       
       
       
       
       
       
        // private int numeroBanco;
        // private int numeroAgencia;
        // private int numeroConta;
        // private string titular ContaCorrente;
        // protected double saldo;
        // public DebitoContaCorrente
        // (int numeroBanco, numeroAgencia, numeroConta, string titular)
        // {
        // this. numeroBanco = numeroBanco;
        // this. numeroAgencia = numeroAgencia;
        // this. numeroConta = numeroConta;
        // this.titular = titular;
        // }
        // // nao sei se está correto
        // public boolean sacar(double quantia) {
        // if (this.saldo < quantia ) {
        // return false;
        // } else {
        // this.saldo -= quantia;
        // return true;
        // }
        // //Nao sei se está correto
        // public boolean debitar(double valor) {
        // this.saldo += valor
        // return true;
        // public double get Saldo(){
        // return this.saldo;
        // }
    }
}
