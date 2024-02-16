using ConsoleApp1.Errors;
using ConsoleApp1.Models;

namespace ConsoleApp1.Service
{
    internal class SearcherBeer
    {
        private readonly List<Beer> _beers = new()
        {
            new Beer() { Name = "Heineken", Alcohol = 5, Mark = "Austin", Milliliters = 260 },
            new Beer() { Name = "Budweiser", Alcohol = 4, Mark = "Santos", Milliliters = 260 },
            new Beer() { Name = "Corona", Alcohol = 4, Mark = "Bavaria", Milliliters = 340 },
        };


        public double GetAlcohol(string name) {
            var alcohol = this._beers.FirstOrDefault(b => b.Name == name)!.Alcohol;
            return alcohol;
        }

        public int GetMilliliters(string name) => this._beers.First(b => b.Name == name).Milliliters;

        public int GetQuantity() => this._beers.Count;
    }
}
