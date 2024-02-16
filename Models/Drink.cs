namespace ConsoleApp1.Models
{
    internal class Drink
    {
        public string Name { get; set; }
        public int Milliliters { get; set; }
        public string Mark { get; set; }

        public void Drinking(int milliliters) { 
            this.Milliliters -= Milliliters;
        }
    }
}
