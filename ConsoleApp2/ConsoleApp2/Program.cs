using System;
using ConsoleApp2.ClassAndObjects;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFirstAsset = new Asset();
            myFirstAsset.Name = "Apartment";
            Console.WriteLine("Asset Value: {0}", myFirstAsset.GetMonetaryValue());

            var stock = new Stock()
            {
                Name = "Zion Inc.", 
                NumberOfShares = 23
            };
            Program.Display(stock);
            Console.WriteLine("Asset value: {0}", stock.GetMonetaryValue());

            var house = new House()
            {
                Name = "Broadway Apt",
                MortgageAmount = 585000
            };
            Program.Display(house);
            Console.WriteLine("Asset value: {0}", house.GetMonetaryValue());

            // Casting: is the operation that converts references
            // References are variable name or object names
            Stock msft = new Stock() { Name = "MSFT", NumberOfShares = 12 };
            Asset asset = msft; // Upcast: creates a base class ref. from a subclass ref/

            Console.WriteLine("is msft equal to asset object? {0}", asset == msft);

            Stock s = (Stock)asset; // Downcast
            Console.WriteLine("shares = {0}", s.NumberOfShares);
            Console.WriteLine("is s object equal to asset object? {0}", asset == s);
            Console.WriteLine("is s object equal to msft object? {0}", msft == s);

            // Upcast always works
            // Downcast may fail

            House h = new House() { Name = "Howe St Apt", MortgageAmount = 812000 } ;
            Asset homeAsset = h;
            // Stock stock2 = (Stock)homeAsset; // runtime error InvalidCastException is thrown

            // The as operator: performs a downcast that can evaluate to null when the downcast fails
            Stock stock2 = homeAsset as Stock; // it will set stock2 to null; not exceptions thrown
            if (stock2 != null)
            {
                Console.WriteLine(stock2.NumberOfShares);
            }

            // var shares = (homeAsset as Stock).NumberOfShares; // this will throw NullReferencException

            // the 'is' operator: tests whether a variable matches a pattern
            if (homeAsset is Asset)
            {
                Console.WriteLine("homeAsset is an Asset");
            }

            if (homeAsset is Asset)
            {
                Console.WriteLine("homeAsset is an Asset");
            }

            if (homeAsset is House)
            {
                Console.WriteLine(h.MortgageAmount);
            }
        }

        // this method can display both Stock and House because
        // both of these classes are subclasses of Asset
        // ==>> Polymorphism Object-oriented design - one of main principles
        public static void Display(Asset asset)
        {
            Console.WriteLine("Asset name: {0}", asset.Name);
        }
        public static void Display(House house)
        {
            Console.WriteLine("Asset name: {0}", house.Name);
        }
    }
}
