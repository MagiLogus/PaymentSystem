﻿using System;
using PaymentSystem;

Console.Clear();

Credito cartao = new Credito();
Boleto boleto = new Boleto();
Credito credito = new Credito();
Debito debito = new Debito();
Pagamento pagamento = new Pagamento();

int opcao;
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"");
Console.WriteLine($"*****************************************");
Console.WriteLine($"*****Bem-vindo a nossa loja virtual!*****");
Console.WriteLine($"*****************************************");
Console.WriteLine($"");
Console.ResetColor();

//Menu

do
{   
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine($"");
Console.WriteLine($"*****Menu inicial*****");
Console.WriteLine($"");
Console.WriteLine($"Selecione uma opção:");
Console.WriteLine($"[1] - Registrar Cartão: ");
Console.WriteLine($"[2] - Exibir Cartão registrado: ");
Console.WriteLine($"[3] - Pagamento em boleto: ");
Console.WriteLine($"[4] - Pagamento em cartão de crédito: ");
Console.WriteLine($"[5] - Pagamento em cartão de débito: ");
Console.WriteLine($"[0] - Sair do sistema");
Console.WriteLine($"");
Console.ResetColor();

opcao = int.Parse(Console.ReadLine());

Console.Clear();

switch (opcao)
{
    case 1:
        cartao.SalvarCartao();
        break;
    case 2:
        cartao.ExibirCartao();
        break;
    case 3:
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Por favor, informe o valor da conta a ser paga: ");
        Console.ResetColor();
        Console.ResetColor();
        boleto.Valor = float.Parse(Console.ReadLine());
        boleto.Registrar();
        Console.Write("Aperte <Enter> para sair... ");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        break;
    case 4:
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Por favor, informe o valor da conta a ser paga: ");
        Console.ResetColor();
        credito.Valor = float.Parse(Console.ReadLine());
        credito.Pagar();
        break;
    case 5:
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Por favor, informe o valor da conta a ser paga: ");
        Console.ResetColor();
        debito.Valor = float.Parse(Console.ReadLine());
        debito.Pagar();
        break;       
    case 0:
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Saindo do sistema...");
        Console.ResetColor();
        Console.Clear();
        break;
    default:
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Opção inválida. Tente novamente.");
        Console.ResetColor();
        break;
}

} while (opcao != 0);