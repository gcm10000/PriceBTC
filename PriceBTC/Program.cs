using System;
using System.Globalization;

namespace PriceBTC
{
    class Program
    {
        //Comissão de compra e venda do Mercado Bitcoin
        static double Comission = 0.01f;
        static void Main(string[] args)
        {
            Console.Write("Antigo preço: ");
            double oldPrice = double.Parse(Console.ReadLine());
            Console.Write("Preço atual: ");
            double newPrice = double.Parse(Console.ReadLine());
            double pp = 1;
            double percentageProcessor = 0.00f;
            if (newPrice < oldPrice)
            {
                pp = (newPrice / oldPrice);
                percentageProcessor = (1 / pp) - 1;
            }
            else if (oldPrice < newPrice)
            {
                pp = (oldPrice / newPrice);
                percentageProcessor = pp - 1;
            }


            Console.WriteLine(Environment.NewLine + $"Rentabilidade bruta: {(percentageProcessor.ToString("P", new CultureInfo("pt-BR", false).NumberFormat))}");
            Console.WriteLine(Environment.NewLine + $"Rentabilidade líquida: {(percentageProcessor - Comission).ToString("P", new CultureInfo("pt-BR", false).NumberFormat)}");
            Pause();
        }
        static void Pause()
        {
            Console.Write("Pressione uma tecla para continuar. . .");
            Console.ReadKey();
        }
    }
}
