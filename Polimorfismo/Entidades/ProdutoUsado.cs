using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            :base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return
                Nome +
                " (used) $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                " (Data de Fabricação: "+
                DataFabricacao.ToString("dd/mm/yyyy") +
                ")";
        }
    }
}
