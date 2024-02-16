using ConsoleApp1.Service;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            var beers = new List<EvilBeer>()
            {
                new() {Alcohol = 10, Name = "BBC"},
                new() {Alcohol = 15, Name = "Heineken"},
                new() {Alcohol = 7,  Name = "Brave"},
                new() {Alcohol = 5,  Name = "Budweiser"},
            };

            ShowBeerThatIGetDrunk(beers, beer => beer.Alcohol > 6);
        }

        static void ShowBeerThatIGetDrunk(List<EvilBeer> beers, Predicate<EvilBeer> predicate)
        {
            var evilBeer = beers.FindAll(predicate);
            evilBeer.ForEach(beer => Console.WriteLine(beer.Name));
        }
    }

    internal class EvilBeer
    {
        public string Name { get; set; }
        public int Alcohol { get; set; }
    }
}
