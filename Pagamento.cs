namespace PaymentSystem
{
    public class Pagamento 
    {

        DateTime Data = DateTime.Now;
        public float Valor;
        
        public string Cancelar()
        {
            Console.WriteLine($"Cancelando opreacao...");
            Thread.Sleep(1000);

            Console.WriteLine($"Voltando para o menu inicial...");
            Thread.Sleep(2000);

            Console.Clear();
            
            return "";            
        }

        public void DataVencimento(){
            Console.WriteLine($"Vencimento em {Data.ToString("dd/MM/yyyy")}");
            
        }
    }
}
