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
        Int é o tipo de método de acordo com a ação de método
        soma_dois_numeros é o nome do método para sua identificação quando invocado pelo formulários (um ou mais formularios)
        (int x e int y) são tipo"variaveis" são parametros.
        Obs parametros são informações necessária o metodo funcionar.
        O que está no return  - é o retorno do método exemplo demonstração de ma formula matemática.*/

        public int soma_dois_numeros( int x, int y)
        {
            return x + y;
        }
    }
}
