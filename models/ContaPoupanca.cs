using System;
using ContaUsuario.models.Classe;
using ContaUsuario.models.Interface;

public class ContaPoupanca : Conta, IContaInvestimento
{
	public ContaPoupanca()
	{ }
	public decimal Taxa { get; set; }

	public ContaPoupanca(decimal taxa)
	{
		Taxa = taxa;
	}

	public override void Depositar(decimal valor)
	{
		Saldo += valor;
	}

	public override void Retirar(decimal valor)
	{
		if (Saldo > 0)
		{
			Saldo += Taxa;

		}
		Console.WriteLine($" o saldo nao é suficiente, valor: ${Saldo}");
	}

	public void CalcularRetornoInvestimento()
	{
		throw new NotImplementedException();
	}
  
}

