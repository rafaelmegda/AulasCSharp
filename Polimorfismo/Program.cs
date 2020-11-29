using Polimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProdutos = new List<Produto>();

            Console.Write("Entre com o número de Produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Dados do Produto #" + i + ":");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipoProduto = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(tipoProduto == 'c')
                {
                    listaProdutos.Add(new Produto(nome, preco));
                }
                else if(tipoProduto == 'u')
                {
                    Console.Write("Data de Fabricacao (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    listaProdutos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else
                {
                    Console.Write("Custos Alfandega: ");
                    double custosAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaProdutos.Add(new ProdutoImportado(nome, preco, custosAlfandega));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Preço das Etiquetas");

            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine(produto.PrecoEtiqueta());
            }

            Console.ReadLine();
        }
    }
}
