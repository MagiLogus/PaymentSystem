using PaymentSystem;

namespace PaymentSystem
{
    public class Credito : Cartao
    {
        public double Valor;
        public float TaxaJuros = 0.5f;
        public int Parcelas;
        public int Meses;
        public float Limite { get; private set; } = 10000;
        
        void juros()
        {
            if (Parcelas <= 6)
            {
                TaxaJuros = 0.05f;
            }
            else if (Parcelas >= 7 && Parcelas <= 12)
            {
                TaxaJuros = 0.08f;
            }
            Console.Clear();
            Meses = Parcelas;
            double ValorFinal = Valor * Math.Pow(1 + TaxaJuros, Meses);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor inicial: R${Valor:F2}");
            Console.WriteLine($"Taxa de juros: {TaxaJuros:P}");
            Console.WriteLine($"Número de meses: {Meses}");
            Console.WriteLine($"Valor final: R${ValorFinal:F2}");
            Console.ResetColor();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Deseja prosseguir com o pagamento?");
            Console.WriteLine("Digite 'S' para 'sim' ou 'N' para 'não':");
            Console.ResetColor();
            char resposta = char.Parse(Console.ReadLine().ToLower());
            
            Console.Clear();
            if (resposta == 's')
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pagamento efetuado com sucesso!");
                Console.WriteLine($"Valor: R${ValorFinal:F2}");
                Console.ResetColor();
            }
            else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operação cancelada pelo usuário.");
                Console.ResetColor();
            }
        }

        public override void Pagar()
        {
            SalvarCartao();
            Console.Clear();
            if (Limite < Valor)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Limite ultrapassado!");
                Console.ResetColor();

            }
            else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"");
                Console.WriteLine($"Obrigado por optar por pagar com cartão de crédito");
                Console.WriteLine($"Gostaria de parcelar sua compra?");
                Console.ResetColor();
                
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Para prosseguir, por favor, digite 'S' para 'sim' ou 'N' para 'não'.");
                Console.ResetColor();

                char resp = char.Parse(Console.ReadLine().ToLower());
                if (resp == 's')
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"Certo, você optou por parcelar sua compra.");
                    Console.WriteLine($"Gostaríamos de lembrar que nossa loja parcela em até 12X.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.ResetColor();

                   volta:
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Por favor, informe o número de parcelas desejado apenas com números:");
                    Console.Write($"Quantas parcelas você gostaria de fazer? Por favor, informe apenas com números:");
                    Console.ResetColor();
                    Parcelas = int.Parse(Console.ReadLine());
                    if (Parcelas <= 6)
                    {
                        juros();
                    }
                    else if (Parcelas >= 7 && Parcelas <= 12)
                    {
                        juros();
                    }
                    else if (Parcelas > 12)
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Lamentamos informar que não é possível parcelar em mais de 12X.");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        goto volta;
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Houve um erro nos seu dados, verifique novamente.");
                        Console.ResetColor();
                        return;
                    }
                }
                else if (resp == 'n')
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Deseja prosseguir com o pagamento à vista?");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Digite 'S' para 'sim' ou 'N' para 'não':");
                    Console.ResetColor();
                    char resposta = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                    if (resposta == 's')
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Pagamento efetuado com sucesso!");
                        Console.WriteLine($"Valor: R${Valor:F2}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Operação cancelada pelo usuário.");
                        Console.ResetColor();
                    }
                }
                else
                {   
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inválida.");
                    Console.ResetColor();
                    return;
                }
            }
        } 
    }
}