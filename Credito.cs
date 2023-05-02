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

            Console.WriteLine($"Valor inicial: R${valor_inicial:F2}");
            Console.WriteLine($"Taxa de juros: {taxa_juros:P}");
            Console.WriteLine($"Número de meses: {num_meses}");
            Console.WriteLine($"Valor final: R${valor_final:F2}");
        }


        public float Limite;
        public int Qntdparcelas;
        public override void Pagar()
        {
            Console.WriteLine($" Sua escolha foi o 'Credito' ");
            Console.WriteLine($" Voce gostaria de parcelar ");
            Console.WriteLine($" Use somente 'S' ou 'N' ");

            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.Clear();
                Console.WriteLine($" Certo voce ira parcelar");
                Console.WriteLine($" Nos so parcelamos em ate 12X ");
                Thread.Sleep(3000);
                Console.Clear();

                volta:
                Console.WriteLine($"Em numeros apenas");
                Console.Write($"Quantas parcelas voce gostaria de fazer:");
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
                    Console.WriteLine($"Nao parcelamos mais que 12X");
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
                Console.WriteLine($"Voce ira fazer o pagamento a vista ");
                Console.WriteLine($"{valor_inicial:C2}");
                
            }

        }



    }



}