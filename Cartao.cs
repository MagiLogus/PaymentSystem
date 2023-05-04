using System;

namespace PaymentSystem
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string Cvv { get; set; }
        public abstract void Pagar();
        
        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do seu cartão: ");
            Console.WriteLine("1 - Visa");
            Console.WriteLine("2 - Mastercard");
            Console.WriteLine("3 - American Express");
            string escolha = Console.ReadLine();

            switch(escolha)
            {
                case "1":
                    this.Bandeira = "Visa";
                    break;
                case "2":
                    this.Bandeira = "Mastercard";
                    break;
                case "3":
                    this.Bandeira = "American Express";
                    break;
                default:
                    Console.WriteLine("Bandeira inválida.");
                    break;
            }

            Console.WriteLine($"Informe o número do seu cartão: ");
            this.NumeroCartao = Console.ReadLine();

            Console.WriteLine($"Informe o nome do titular do cartão: ");
            this.Titular = Console.ReadLine();

            Console.WriteLine($"Informe o codigo de segurança do seu cartão: ");
            this.Cvv = Console.ReadLine();

            Console.WriteLine($"Cartão salvo com sucesso!");
            
    
            return "";
        }
        
        public string ExibirCartao()
        {
             Console.WriteLine(@$"
                    ┌─────────────────────────────────────────────┐
                                  Cartão {this.Bandeira}    
                                                                
                       Número do cartão: {this.NumeroCartao} 
                       Titular: {this.Titular}                 
                       Bandeira: {this.Bandeira}           
                       CVV:{this.Cvv} 
                                                                
                    └─────────────────────────────────────────────┘
            ");  
            return"";
        }
    }
}
