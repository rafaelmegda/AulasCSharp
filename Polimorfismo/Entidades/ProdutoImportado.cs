using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Entidades
{
    class ProdutoImportado : Produto
    {
        public double CustoAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double custoAlfandega)
            :base(nome, preco)
        {
            CustoAlfandega = custoAlfandega;
        }

        public double precoTotal()
        {
            return Preco + CustoAlfandega;
        }

        public override string PrecoEtiqueta()
        {
            return Nome +
                " $ " +
                precoTotal().ToString("F2", CultureInfo.InvariantCulture) +
                "(Custos Alfandega: $ " +
                CustoAlfandega.ToString("F2", CultureInfo.InvariantCulture) +
                ")";
        }
    }
}
