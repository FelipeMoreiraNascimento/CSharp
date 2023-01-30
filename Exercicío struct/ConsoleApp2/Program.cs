using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados Atualizados: \n" + p);
            
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados Atualizados: \n" + p);

            Console.ReadKey();
        }
    }
}
