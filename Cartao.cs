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
            this.Bandeira = Console.ReadLine();

            Console.WriteLine($"Informe o número do seu cartão: ");
            this.NumeroCartao = Console.ReadLine();

            Console.WriteLine($"Informe o nome do titular do cartão: ");
            this.Titular = Console.ReadLine();

            Console.WriteLine($"Informe o codigo de segurança do seu cartão: ");
            this.Cvv = Console.ReadLine();
    
            return "";
        }
        
        public string ExibirCartao()
        {
             Console.WriteLine(@$"
            Cartão salvo com sucesso!
            ╭-------------------------------------------------╮
            |               Cartão {this.Bandeira}            |
            | Número do cartão: {this.NumeroCartao}           |
            | Titular: {this.Titular}                         |
            | Bandeira: {this.Bandeira}    CVV:{this.Cvv}     |
            ╰-------------------------------------------------╯
            ");
            
            return"";
        }
    }
}