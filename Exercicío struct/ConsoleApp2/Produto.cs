using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingStruct
{
    internal struct Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Preco + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
