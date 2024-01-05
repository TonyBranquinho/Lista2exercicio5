using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Leia codigo e quantidade");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double valor = 0;
            double saida = 0;
            if (codigo == 1) {
                valor = 4.00;
            }
            else if (codigo == 2) {
                valor = 4.50;
            }
            else if (codigo == 3) {
                valor = 5.00;
            }
            else if (codigo == 4) {
                valor = 2.00;
            }
            else if (codigo == 5) {
                valor = 1.50;
            }

            double total = valor * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CI));
        }
    }
}