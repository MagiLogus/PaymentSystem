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
          Console.WriteLine($"O seu saldo é de {this.saldo}");
          
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
    }
}
