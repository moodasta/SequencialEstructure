using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");

            string[] pecal = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(pecal[0]);
            int quantidadePeca1 = int.Parse(pecal[1]);
            double valorUnitarioPeca1 = double.Parse(pecal[2], culture);

            int codigoPeca2 = int.Parse(peca2[0]);
            int quantidadePeca2 = int.Parse(peca2[1]);
            double valorUnitarioPeca2 = double.Parse(peca2[2], culture);

            double valorTotal = (quantidadePeca1 * valorUnitarioPeca1) + (quantidadePeca2 * valorUnitarioPeca2);

            Console.WriteLine("VALOR A PAGAR: R$" + valorTotal.ToString("F2", culture));
        }
    }
}
