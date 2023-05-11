namespace PaymentSystem
{
    public class Debito : Cartao
    {
        public float saldo { get; private set; } = 5000;

        public override void Pagar()
        {
            SalvarCartao();
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"");
            Console.WriteLine($"Obrigado por optar por pagar com cartão de débito");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O seu saldo atual é de R${this.saldo}");
            Thread.Sleep(3500);
            Console.ResetColor();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deseja prosseguir com o pagamento?");
            Console.ResetColor();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Digite 'S' para 'sim' ou 'N' para 'não':");
            Console.ResetColor();
            char resposta = char.Parse(Console.ReadLine().ToLower());
            Thread.Sleep(2500);
            Console.Clear();
            if (resposta == 's')
            {
                if (Valor > saldo)
                {
                    Console.Beep(1200,1200);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Saldo insuficiente!");
                    Console.ResetColor();
                    Console.Write("Aperte <Enter> para confirmar... ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.Clear();
                }
                else if (saldo >= Valor)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    float novoSaldo = saldo - Valor;
                    Console.WriteLine($"Pagamento efetuado com sucesso!");
                    Console.WriteLine($"O seu novo saldo é de: R${novoSaldo}");
                    Thread.Sleep(3000);
                    Console.Write("Aperte <Enter> para confirmar... ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.Clear();
                    
                    Console.ResetColor();
                }
                else
                {
                    Console.Beep(1200,1200);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inválida, tente novamente!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operação cancelada pelo usuário.");
                Console.ResetColor();
            }
        }
    }
}
