using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_carro
{
    class Carro : Veiculo
    {
        private int portas;
        private string marca;
        private int quilometragem;

        public void setPortas(int portas)
        {
            this.portas = portas;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public void setQuilometragem(int quilometragem)
        {
            this.quilometragem = quilometragem;
        }

        public int getPortas()
        {
            return this.portas;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public int getQuilometragem()
        {
            return this.quilometragem;
        }
    }
}
