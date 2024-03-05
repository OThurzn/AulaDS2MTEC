using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clculadora_de_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos anos você tem: ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Você viveu em torno de " + (anos * 365) + " dias");
            Console.ReadKey();
        }
    }
}
