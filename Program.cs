using System;
using PaymentSystem;

int opcao;

Console.WriteLine($"");
Console.WriteLine($"*****************************************");
Console.WriteLine($"*****Bem-vindo a nossa loja virtual!*****");
Console.WriteLine($"*****************************************");
Console.WriteLine($"");

//Menu
do
{   
Console.WriteLine($"*****Menu inicial*****");
Console.WriteLine($"");
Console.WriteLine($"Selecione uma opção:");
Console.WriteLine($"[1] - Exibir Cartão registrado: ");
Console.WriteLine($"[2] - Pagamento em boleto: ");
Console.WriteLine($"[3] - Pagamento em cartão de crédito: ");
Console.WriteLine($"[4] - Pagamento em cartão de débito: ");
Console.WriteLine($"[5] - Cancelar operação ");
Console.WriteLine($"[0] - Sair do sistema");
Console.WriteLine($"");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        break;
    case 2:
       
        break;
    case 0:
        Console.WriteLine($"Saindo do sistema...");
        break;
    default:
        Console.WriteLine($"Opção inválida. Tente novamente.");
        break;
}

} while (opcao != 0);
