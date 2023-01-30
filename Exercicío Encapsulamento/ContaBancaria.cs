using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome) 
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double depositoInicial) : this(conta, nome)
        {
            Depositar(depositoInicial);
        }

        public double Saque(double sacar)
        {
            return Saldo =  (Saldo -  sacar) - 5.00;
        }

        public double Depositar(double deposito)
        {
            return Saldo += deposito;
        }

        public override string ToString()
        {
            return "Conta: " + Conta + ", Nome: " + Nome + ", Saldo : R$ " + Saldo.ToString("F2");
        }

    }
}
