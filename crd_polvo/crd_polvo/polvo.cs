using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace crd_polvo {

    class polvo : conexao
    {
        private string codigo;
        private string especie;
        private string habitat;
        private string tamanho;
        private int peso;
        private string cor;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public void setEspecie(string especie)
        {
            this.especie = especie;
        }
        public string getEspecie()
        {
            return this.especie;
        }

        public void setHabitat(string habitat)
        {
            this.habitat = habitat;
        }
        public string getHabitat()
        {
            return this.habitat;
        }

        public void setTamanho(string tamanho)
        {
            this.tamanho = tamanho;
        }
        public string getTamanho()
        {
            return this.tamanho;
        }

        public void setPeso(int peso)
        {
            this.peso = peso;
        }
        public int getPeso()
        {
            return this.peso;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }

        //criação do método inserir()
        public void inserir()
        {
            string query = "insert into polvo(especie, habitat, tamanho, peso, cor) values ('" + getEspecie() + "', '" + getHabitat() + "', '" + getTamanho() + "', '" + getPeso() + "', '" + getCor() + "')";
            //Abrir conexão, enviar ao banco de dados e fechar conexão
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        //Método para visualizar os dados
        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from polvo";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            this.fecharconexao();
            return dt;
        }

        //Método para excluir os dados
        public void Excluir()
        {
            string query = "delete from polvo where codigo_polvo= '" + getCodigo() + "'";
            if (this.abrirconexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
