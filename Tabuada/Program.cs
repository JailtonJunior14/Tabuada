using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tabuada: ");
            int tabu = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de vezes");
            int vezes = int.Parse(Console.ReadLine());

            int cont = 1;

            while (cont <= vezes)
            {
                int resultado = tabu * cont;
                Console.WriteLine(tabu + "X" + cont + "=" + resultado);
                cont++;
            }

            Console.ReadKey();
        }
    }
}
