namespace PaymentSystem
{
    public class Pagamento : Cartao
    {

        DateTime data = DateTime.Now;
        float valor;

        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}