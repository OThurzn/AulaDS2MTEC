using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploOrientaçãoObjeto
{
    class operacoes_matematicas
    {
        
        //Atributos


        /*Metodos (Ação) - Formula Matematica
        Definição de métodos:
        Todo método deve ter uma visibilidade (public ou private) os metodos sempre serão públicos.
        double é o tipo de método de acordo com a ação de método
        soma_dois_numeros é o nome do método para sua identificação quando invocado pelo formulários (um ou mais formularios)
        (double x e double y) são tipo"variaveis" são parametros.
        Obs parametros são informações necessária o metodo funcionar.
        O que está no return  - é o retorno do método exemplo demonstração de ma formula matemática.*/

        public double soma_dois_numeros(double x, double y)
        {
            return x + y;
        }
        public double subtrai_dois_numeros(double x, double y)
        {
            return x - y;
        }
        public double multiplica_dois_numeros(double x, double y)
        {
            return x * y;
        }
        public double divisao_dois_numeros(double x, double y)
        {
            return x / y;
        }
    }
    }
    

