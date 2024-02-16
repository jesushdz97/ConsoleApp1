using ConsoleApp1.Models;

namespace ConsoleApp1.Service
{
    internal class SearcherBeer
    {
        List<Beer> beers = new List<Beer>() {
            new() { Name = "Heineken", Alcohol = 5, Mark = "Amstel", Milliliters = 350 },
            new() { Name = "Budweiser", Alcohol = 5, Mark = "Austin", Milliliters = 350 },
            new() { Name = "Corona", Alcohol = 5, Mark = "Anheuser-Busch InBev", Milliliters = 350 },
        };

        public double GetAlcohol(string name) => beers.First(b => b.Name == name).Alcohol;
    }
}
