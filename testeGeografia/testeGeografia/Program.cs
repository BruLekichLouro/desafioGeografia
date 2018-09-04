using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeGeografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de uma cidade");
            string local = Console.ReadLine();

            Cidades entrada = new Cidades();
            entrada.procuraCidade(local);

            Console.ReadLine();
        }
    }
}
