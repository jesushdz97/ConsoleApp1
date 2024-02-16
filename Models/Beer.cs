using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    internal class Beer : Drink, IAlcoholicBeverage
    {
        public double Alcohol { get; set; }
        public void MaximumRecommendedAmount()
        {
            throw new NotImplementedException();
        }
    }
}
