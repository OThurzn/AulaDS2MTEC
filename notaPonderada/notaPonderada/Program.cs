using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, prova1, prova2, prova3;
            Console.Write("Digite a nota alcançada na primeira prova: ");
            prova1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota alcançada na segunda prova: ");
            prova2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota alcançada na terceira prova: ");
            prova3 = double.Parse(Console.ReadLine());
            media = ((2 * prova1) + (3 * prova2) + (5 * prova3)) /10;

            Console.WriteLine($"a média final é: {media}");
            Console.ReadKey();
        }
    }
}
