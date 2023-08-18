// See https://aka.ms/new-console-template for more information
using ContaUsuario.models;
using ContaUsuario.models.Classe;

Conta ContaC = new ContaCorrente();
Conta ContaP = new ContaPoupanca();

ContaC.Numero = 23;
ContaC.Saldo = 100;
ContaC.Depositar(ContaC.Saldo);
Console.WriteLine(ContaC.Saldo);
ContaC.Retirar(50);
Console.WriteLine(ContaC.Saldo);
Console.WriteLine(ContaC.Numero);