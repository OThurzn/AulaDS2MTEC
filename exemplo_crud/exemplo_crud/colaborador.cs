using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca de conexão do SQL
using MySql.Data;
using MySql.Data.MySqlClient;
//Adicionar a biblioteca para visualizar os dados da DataGridView
using System.Data;

namespace exemplo_crud
{
    class colaborador : conexao
    {
        private string codigo;
        private string nome;
        private string sobrenome;
        private string cpf;
        
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCPF()
        {
            return this.cpf;
        }
        //criação do método inserir()
        public void inserir()
        {
            string query = "insert into colaborador(nome_colaborador,sobrenome_colaborador,cpf_colaborador)values('"+getNome() + "', '" + getSobrenome() +"','"+getCPF()+"' )";
            //Abrir conexão, enviar ao banco de dados e fechar conexão
            if(this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }
        //Metódo para visualizqar os dados
        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from colaborador";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Metódo para excluir os dados
        public void Excluir()
        {
            string query = "delete from colaborador where codigo_colaborador= '" + getCodigo() + "'";
            if (this.abrirconexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
