using System;
using System.Threading;

namespace PaymentSystem
{
    public class Credito : Cartao
    {

        public double valor_inicial = 500;
        public float taxa_juros = 0.5f;
        public int num_meses ;
        void juros()
        {
            if (Qntdparcelas <=6 )
            {
                taxa_juros = 0.05F;
            }
            else if (Qntdparcelas >= 7 && Qntdparcelas <= 12)
            {
                taxa_juros = 0.08F;
            }

            
            num_meses = Qntdparcelas;
            double valor_final = valor_inicial * Math.Pow(1 + taxa_juros, num_meses);

            Console.WriteLine($"Valor inicial: R${valor_inicial:C2}");
            Console.WriteLine($"Taxa de juros: {taxa_juros:P}");
            Console.WriteLine($"Número de meses: {num_meses}");
            Console.WriteLine($"Valor final: R${valor_final:C2}");
        }


        private float Limite;
        public int Qntdparcelas;
        public override void Pagar()
        {
            Console.WriteLine($"");
            Console.WriteLine($"Obrigado por optar por pagar com cartão de crédito");
            Console.WriteLine($"Gostaria de parcelar sua compra?");
            Console.WriteLine($"Para prosseguir, por favor, digite 'S' para 'sim' ou 'N' para 'não'.");

            char resp = char.Parse(Console.ReadLine().ToLower());
            if (resp == 's')
            {
                Console.Clear();
                Console.WriteLine($"Certo, você optou por parcelar sua compra.");
                Console.WriteLine($"Gostaríamos de lembrar que nossa loja parcela em até 12X.");
                Thread.Sleep(5000);
                Console.Clear();

                volta:
                Console.WriteLine($"Por favor, informe o número de parcelas desejado apenas com números:");
                Console.Write($"Quantas parcelas você gostaria de fazer? Por favor, informe apenas com números:");
                Qntdparcelas = int.Parse(Console.ReadLine());
                if (Qntdparcelas <= 6)
                {
                    juros();
                }

                else if (Qntdparcelas >=7 && Qntdparcelas <=12)
                {
                    juros();
                }

                else if (Qntdparcelas >12)
                {
                    Console.WriteLine($"Lamentamos informar que não é possível parcelar em mais de 12X.");
                    Thread.Sleep(3000);
                    goto volta;
                    
                }

                if (NumeroCartao.Length == 16 && Cvv.Length == 3)
                {
                    Console.WriteLine($"Seu cartao foi validado");
                }

                else
                {
                    Console.WriteLine($"Houve um erro nos seu dados, verifique novamente.");
                    return;
                }

            }

            else
            {
                Console.WriteLine($"Obrigado por optar pelo pagamento à vista.");
                Console.WriteLine($"{valor_inicial:C2}");     
            }

        }



    }



}