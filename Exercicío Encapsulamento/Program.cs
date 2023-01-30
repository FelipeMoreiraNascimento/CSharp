using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Digite o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 'S' || escolha == 's') 
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numConta, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numConta, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: \n" + conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados: \n" + conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            deposito = double.Parse(Console.ReadLine());
            conta.Saque(deposito);
            Console.WriteLine("Dados da conta atualizados: \n" + conta);

            Console.ReadKey();
        }
    }
}
