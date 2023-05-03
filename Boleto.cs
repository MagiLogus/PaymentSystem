using System;

namespace PaymentSystem
{
    public class Boleto : Pagamento  // Herença da classe Pagamento para obter o valor do pagamento 

    {

        public string numeroBoleto { get; set; }

        public double valorComDesconto { get; set; }
        
        private string CodigoDeBarras ()

        {
            int valor = 300;
             // Inicializar objeto da classe Random
             Random random = new Random();

             // Calcular o valor do desconto
            double desconto = valor * 0.12;
            valorComDesconto = valor - desconto;

            // Gerar valores aleatórios para os campos do boleto
            string banco = random.Next(100, 1000).ToString();
            string nossoNumero = random.Next(100000000, 1000000000).ToString();
            string fatorVencimento = random.Next(1, 10000).ToString();

            // Converter os valores para strings e concatenar os campos do boleto
             numeroBoleto = $"{banco}{fatorVencimento}{"0000000000"}{nossoNumero}{valorComDesconto.ToString("0.00").Replace(",", "")}";


            return "";
        }

        public void Registrar ()
        {
            CodigoDeBarras();
            
            // Exibir o código de barras 
            Console.WriteLine($"Código de barras: {numeroBoleto}");

            Console.WriteLine($"Valor a ser pago: R${valorComDesconto.ToString("0.00")}");
        }


        // // Exibir o código de barras e valor a ser pago
        
         

    }
}