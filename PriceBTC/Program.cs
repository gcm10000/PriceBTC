using System;

namespace PriceBTC
{
    class Program
    {
        //Comissão de compra e venda do Mercado Bitcoin
        static float Comission = 0.01f;
        static void Main(string[] args)
        {
            Console.Write("Antigo preço: ");
            float oldPrice = float.Parse(Console.ReadLine());
            Console.Write("Preço atual: ");
            float newPrice = float.Parse(Console.ReadLine());
            float pp = 1;
            float percentageProcessor = 0.00f;
            if (newPrice < oldPrice)
            {
                pp = (newPrice / oldPrice);
                percentageProcessor = (1 - pp) * (-1);
            }
            else if (oldPrice < newPrice)
            {
                pp = (oldPrice / newPrice);
                percentageProcessor = 1 - pp;
            }

            Console.WriteLine(Environment.NewLine + $"Rentabilidade bruta: {(percentageProcessor * 100)}");
            Console.WriteLine(Environment.NewLine + $"Rentabilidade líquida: {(percentageProcessor - Comission) * 100 }");
        }
    }
}
