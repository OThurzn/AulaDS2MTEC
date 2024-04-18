using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_poliformismo
{
    class empregado
    {
        private string nome;
        private string sobrenome;
        private string CPF;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        //Classe empregada a super classe
        //Metodo virtual é um metodo que pode ser substituido por outro método do mesmo nome
        public virtual Double vencimento (double valor)
        {
            valor = 0;
            return valor;
        }
    }
}
