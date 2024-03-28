using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consorcioOO
{
    class operacoes
    {
        public double ValorPago(double pagas, double valor)
        {
            return pagas * valor;
        }
        public double ValorSaldo(double total, double pagas, double valor)
        {
            return (total - pagas) * valor;
        }
    }
}
