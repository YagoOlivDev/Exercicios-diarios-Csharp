using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set ; } = 0;

        public Conta(string _nome, int _numeroconta)
        {
            NomeTitular = _nome;
            NumeroConta = _numeroconta;
        }

        public bool Sacar(double valor)
        {
            double taxaJuros = 5;
            bool saqueRealizado = Saldo>=valor+taxaJuros;
            Saldo = saqueRealizado ? Saldo - (valor + taxaJuros) : Saldo;
            Console.WriteLine($"Saque de R${valor} {(saqueRealizado ? "Realizado com sucesso" : "Não realizado")}");
            return saqueRealizado;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void DadosConta()
        {
        Console.WriteLine("=-=Dados da conta=-=");
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {NomeTitular}");
        Console.WriteLine($"Saldo: R${Saldo}");
        }
    }
}