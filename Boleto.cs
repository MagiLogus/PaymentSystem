using System;
using PaymentSystem;

namespace PaymentSystem
{
    public class Boleto : Pagamento // Herança da classe Pagamento para obter o valor do pagamento 
    {
        public string NumeroBoleto { get; set; }
        public double valorComDesconto { get; set; }
        
        private string CodigoDeBarras()
        {
            // Inicializar objeto da classe Random
            Random random = new Random();

            // Calcular o valor do desconto
            double desconto = this.Valor * 0.12;
            valorComDesconto = this.Valor - desconto;

            // Gerar valores aleatórios para os campos do boleto
            string banco = random.Next(100, 1000).ToString();
            string nossoNumero = random.Next(100000000, 1000000000).ToString();
            string fatorVencimento = random.Next(1, 10000).ToString();

            // Converter os valores para strings e concatenar os campos do boleto
            NumeroBoleto = $"{banco}{fatorVencimento}{"0000000000"}{nossoNumero}{valorComDesconto.ToString("0.00").Replace(",", "")}";

            return "";
        }

        public void Registrar()
        {
            Console.WriteLine("Deseja prosseguir com o pagamento? Digite S para SIM ou N para NÃO");
            string opcao = Console.ReadLine().ToUpper();
    
            if (opcao == "S")
            {
                CodigoDeBarras();
                BarraCarregamento("Registrando o boleto bancário, aguarde", 30, 80); // Chama a função da barra de carregamento
                Console.Clear();

                // Exibir o código de barras 
                Console.WriteLine();
                Console.WriteLine($"Código de barras: {NumeroBoleto}");
            
                //  Exibir o código de barras e valor a ser pago
                Console.WriteLine($"Valor a ser pago: R${valorComDesconto.ToString("0.00")}");
                Console.WriteLine();
                DataVencimento();
            }
            else if (opcao == "N")
            {
                Console.WriteLine("Operação cancelada pelo usuário.");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        public void BarraCarregamento(string texto, int quantidadePontinhos, int tempo) // Função pontinhos da barra da carregamento
        {
            Console.Write(texto);
          
            for (var i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
        }
    }
}
