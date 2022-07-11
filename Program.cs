using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            GarotoCaipira gc = new GarotoCaipira();
            gc.Tocar();

            Console.WriteLine();

            GarotoRock gr = new GarotoRock();
            gr.Tocar();

            Console.ReadKey();
        }
    }
}
