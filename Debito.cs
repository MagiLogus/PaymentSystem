namespace PaymentSystem
{
    public class Debito : Cartao
    {
        public float saldo { get; private set; } = 5000;

        public override void Pagar()
        {
            Console.WriteLine($"");
            Console.WriteLine($"Obrigado por optar por pagar com cartão de débito");
            Thread.Sleep(2000);
            Console.WriteLine($"O seu saldo atual é de {this.saldo}");
            Thread.Sleep(3500);

            Console.WriteLine("Deseja prosseguir com o pagamento?");
            Console.WriteLine("Digite 'S' para 'sim' ou 'N' para 'não'.");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                if (Valor > saldo)
                {
                    Console.WriteLine($"Saldo insuficiente!");
                }
                else if (saldo >= Valor)
                {
                    float novoSaldo = saldo - Valor;
                    Console.WriteLine($"Pagamento efetuado com sucesso! O seu novo saldo é de: R${novoSaldo}");
                }
                else
                {
                    Console.WriteLine($"Opção inválida, tente novamente!");
                }
            }
            else
            {
                Console.WriteLine("Operação cancelada pelo usuário.");
            }
        }
    }
}
