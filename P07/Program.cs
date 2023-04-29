﻿using Classes;

var conta = new ContaBancaria("Renato Fernandez", 1000.50m);
Console.Write($"A conta {conta.Numero} foi criada por {conta.Cliente} com saldo inicial de {conta.Saldo}\n\n");

conta.EfetuarSaque(500, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");
conta.EfetuarDeposito(100, DateTime.Now, "Recebimento de um amigo");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");
/*
// Testar saldo negativo.
try
{
    conta.EfetuarSaque(750, DateTime.Now, "Tentativa de saque sem saldo suficiente");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exceção causada por tentativa de saque sem saldo suficiente");
    Console.WriteLine(e.ToString());
}

// Testar que o saldo inicial deve ser positivo.
ContaBancaria contaInvalida;
try
{
    contaInvalida = new ContaBancaria("Inválida", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exceção causada ao criar conta com saldo negativo");
    Console.WriteLine(e.ToString());
    return;
}
*/
Console.WriteLine(conta.ObterHistoricodeConta());

var cartaoDeDebito = new ContaCartaodeDebito("Cartão de Débito", 100, 50);
cartaoDeDebito.EfetuarSaque(20, DateTime.Now, "Café");
cartaoDeDebito.EfetuarSaque(50, DateTime.Now, "Compra de Mantimentos");
cartaoDeDebito.ExecutarTransacoesdeFimdeMes();
cartaoDeDebito.EfetuarDeposito(27.50m, DateTime.Now, "Adicionar algum dinheiro extra para gastar");
Console.WriteLine(cartaoDeDebito.ObterHistoricodeConta());

var poupanca = new ContadeGanhodeJuros("Conta de Poupança", 10000);
poupanca.EfetuarDeposito(750, DateTime.Now, "Economizar dinheiro");
poupanca.EfetuarDeposito(1250, DateTime.Now, "Adicionar mais poupança");
poupanca.EfetuarSaque(250, DateTime.Now, "Necessário para pagar contas mensais");
poupanca.ExecutarTransacoesdeFimdeMes();
Console.WriteLine(poupanca.ObterHistoricodeConta());