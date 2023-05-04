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
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"───────────────────────────────────────────────────────────────────────");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Informe a bandeira do seu cartão: ");
            Console.WriteLine("1 - MasterCard");
            Console.WriteLine("2 - Visa");
            Console.WriteLine("3 - ELO");
            Console.WriteLine("4 - HiperCard");
            Console.WriteLine("5 - Alelo");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"──────────────────────────────────────────────────────────────────────");
            Console.ResetColor();
        
            
            string escolha = Console.ReadLine();

            switch(escolha)
            {
                case "1":
                    this.Bandeira = "MasterCard";
                    break;
                case "2":
                    this.Bandeira = "Visa";
                    break;
                case "3":
                    this.Bandeira = "ELO";
                    break;
                case "4":
                this.Bandeira = "HiperCard";
                break;
                case "5":
                    this.Bandeira = "Alelo";
                    break;
                default:
                    Console.WriteLine("Bandeira inválida.");
                    Console.ResetColor();
                    break;
            }
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Informe o número do seu cartão: ");
            Console.ResetColor();
            this.NumeroCartao = Console.ReadLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Informe o nome do titular do cartão: ");
            Console.ResetColor();
            this.Titular = Console.ReadLine();
            

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Informe o codigo de segurança do seu cartão: ");
            Console.ResetColor();
            this.Cvv = Console.ReadLine();
            

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cartão salvo com sucesso!");
            Console.ResetColor();
            
    
            return "";
            
        }
        
        public string ExibirCartao()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@$"
                    ┌─────────────────────────────────────────────┐
                                  Cartão {this.Bandeira}    
                                                                
                       Número do cartão: {this.NumeroCartao} 
                       Titular: {this.Titular}                 
                       Bandeira: {this.Bandeira}           
                       CVV:{this.Cvv} 
                                                                
                    └─────────────────────────────────────────────┘
            "); 
            Console.ResetColor(); 
            return"";
            
        }
    }
}
