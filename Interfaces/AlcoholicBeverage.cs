namespace ConsoleApp1.Interfaces
{
    internal interface IAlcoholicBeverage
    {
        public double Alcohol { get; set; }
        public void MaximumRecommendedAmount();
    }
}
