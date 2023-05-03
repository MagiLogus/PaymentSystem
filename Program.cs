using System;
using PaymentSystem;

Credito cartao = new Credito();
Boleto boleto = new Boleto();
Credito credito = new Credito();

int opcao;

Console.WriteLine($"");
Console.WriteLine($"*****************************************");
Console.WriteLine($"*****Bem-vindo a nossa loja virtual!*****");
Console.WriteLine($"*****************************************");
Console.WriteLine($"");

Console.WriteLine($"Por favor, informe o valor da conta a ser paga: ");
Console.ReadLine();

//Menu
do
{   
Console.WriteLine($"*****Menu inicial*****");
Console.WriteLine($"");
Console.WriteLine($"Selecione uma opção:");
Console.WriteLine($"[1] - Registrar Cartão: ");
Console.WriteLine($"[2] - Exibir Cartão registrado: ");
Console.WriteLine($"[3] - Pagamento em boleto: ");
Console.WriteLine($"[4] - Pagamento em cartão de crédito: ");
Console.WriteLine($"[5] - Pagamento em cartão de débito: ");
Console.WriteLine($"[6] - Cancelar operação ");
Console.WriteLine($"[0] - Sair do sistema");
Console.WriteLine($"");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        cartao.SalvarCartao();
        break;
    case 2:
        cartao.ExibirCartao();
        break;
    case 3:
        boleto.Registrar();
        break;
    case 4:
        credito.Pagar();
        break;
    case 5:
        break;
    case 6:
        break;        
    case 0:
        Console.WriteLine($"Saindo do sistema...");
        break;
    default:
        Console.WriteLine($"Opção inválida. Tente novamente.");
        break;
}

} while (opcao != 0);
