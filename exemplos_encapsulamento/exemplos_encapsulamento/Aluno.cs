using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos_encapsulamento
{
    class Aluno
    {
        //criar atributo
        private string nome, cpf;
        //A cada atributo necessário criar dois métodos (get e set)
        //Metodo sem retorno possui a palavra void e não possui a palavra return
        //O nome do método deve ser set + o nome do atributo com a primeira pavra em maiusculo (setNome)
        //Metodo set serve para receber os valores digitado ´pelo usuario
        //O valores digitados pelo usuario é armazenado no parametro
        //(string nome) e repassado ao atributo;
        public void setNome(string nome)
        {
            this.nome = nome;

        }
        public void setcpf(string cpf)
        {
            this.cpf = cpf;

        }
        //2 Método
        //Metodo com retorno, o tipo do metodo deve ser do mesmo tipo do atributoque ele está ligado
        //O nome do método deverá ser get + o nome do atributo com a 1 letra em maiusculo (getNome)
        //Método get serve para mostrar valores ao usuário armazenado dentro do método set
        public string getNome ()
        {
            return this.nome;
        }
        public string getcpf()
        {
            return this.cpf;
        }
    }
}
