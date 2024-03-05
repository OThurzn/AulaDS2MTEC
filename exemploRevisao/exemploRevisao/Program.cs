using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca
namespace exemploRevisao
{
    /*Classe padrão do C# é a classe Program
    Classe necessária para execução do projeto.
    Um classe é composta por três coisas.
    1º Nome
    2º Atributos
    3º Métodos
    */
    class Program
    {
        /*método - Ação
        Um método possui nome para ser chamado
        Um método possui argumentos (string[] args)
        O que é um argumento ?
        Informação necessária para execução do método */
        static void Main(string[] args)
        {
            double n1, n2, soma;
            Console.WriteLine("Digite o 1° número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número");
            n2 = double.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma total é: " + soma);

            Console.ReadKey();
        } 
    }
}
