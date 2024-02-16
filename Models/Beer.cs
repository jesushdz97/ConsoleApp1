using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    internal class Beer : Drink, IAlcoholicBeverage
    {
        public Beer()
        {
        }

        public Beer(string name, double alcohol, string mark, int milliliters)
        {
            Name = name;
            Alcohol = alcohol;
            Mark = mark;
            Milliliters = milliliters;
        }

        public double Alcohol { get; set; }
        public void MaximumRecommendedAmount()
        {
            throw new NotImplementedException();
        }
    }
}
