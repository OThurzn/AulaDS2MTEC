using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestacaoAtrasoOO
{
    class operacoes
    {
        public double calcular_juros(double vprest, double tempo, double taxa)
        {
            return vprest* (taxa/100) * tempo;
        }
        public double calcular_valorFinal(double vprest, double taxa, double tempo)
        {
            return vprest + (vprest * (taxa / 100) * tempo);
        }
    }
}
