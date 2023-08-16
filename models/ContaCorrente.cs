using ContaUsuario.models.Classe;
using ContaUsuario.models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaUsuario.models
{
    public class ContaCorrente : Conta
    {

        public override void Retirar(decimal valor)
        {
            Saldo -= valor;   
        }


        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Valor adicionado ao saldo{ Saldo}");
        }


    }
}
