namespace PaymentSystem
{
    public abstract class Cartao
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string Cvv { get; set; }
        public abstract void Pagar();
        public string SalvarCartao()
        {
            Console.WriteLine(@$"
            Cartão salvo com sucesso!
            ╭------------------------------------------╮
            |               Cartão {this.Bandeira}     |
            | Número do cartão: {this.NumeroCartao}    |
            | Titular: {this.Titular}                  |
            | Bandeira: {this.Bandeira}CVV: {this.Cvv} |
            ╰------------------------------------------╯
            ");

            return "";
        }
    }
}