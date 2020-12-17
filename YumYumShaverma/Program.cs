using System;

namespace YumYumShaverma
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaverma GreatestShavermaInTheUniverseBestOfTheBestInTheWorldUDontTryItNever = new Shaverma();
            IProduct MasterSheff = new LavashProduct();
            MasterSheff = new ChickenProductWrapper(MasterSheff);
            MasterSheff = new SauceProductWrapper(MasterSheff);
            MasterSheff = new VegetablesProductWrapper(MasterSheff);
            MasterSheff.AddProduct(GreatestShavermaInTheUniverseBestOfTheBestInTheWorldUDontTryItNever);
            Console.WriteLine(GreatestShavermaInTheUniverseBestOfTheBestInTheWorldUDontTryItNever);
            Console.ReadKey();
        }
    }
}
