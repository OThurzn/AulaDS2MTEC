using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_poliformismo
{
    class comissionario : empregado
    {
        private double totalVenda;
        private double taxaComissao;

        public void setTotalVenda (double totalVenda)
        {
            this.totalVenda = totalVenda;
        }

        public double getTotalVenda()
        {
            return this.totalVenda;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public double getTaxaComissao()
        {
            return this.taxaComissao;
        }

    }
}
