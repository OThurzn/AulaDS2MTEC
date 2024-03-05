using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotosPorcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int vValidos, vBrancos, vNulos, total;
            double resValidos, resBrancos, resNulos;
            Console.WriteLine("Digite quantos votos foram válidos: ");
            vValidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos votos foram brancos: ");
            vBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos votos foram nulos: ");
            vNulos = int.Parse(Console.ReadLine());

            total = vValidos + vBrancos + vNulos;

            resValidos = (vValidos * 100) / total;
            resBrancos = (vBrancos * 100) / total;
            resNulos = (vNulos * 100) / total;

            Console.WriteLine($"Nessa eleição tiveram {total} votos no total, sendo {vValidos} ({resValidos}%) votos válidos, {vBrancos} ({resBrancos}%) votos brancos e {vNulos} ({resNulos}%) votos nulos");
            Console.ReadKey();
        }
    }
}
