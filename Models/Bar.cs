namespace ConsoleApp1.Models
{
    internal class Bar
    {
        public string Name { get; set; }
        public List<Beer> Beers;

        public Bar(string name)
        {  
            Name = name;
        }
    }
}
