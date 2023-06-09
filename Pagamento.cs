namespace PaymentSystem
{
    public class Pagamento
    {

        DateTime Data = DateTime.Now.AddDays(3);
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

        public void DataVencimento()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Vencimento em {Data.ToString("dd/MM/yyyy")}");
            Console.ResetColor();

        }
    }
}
