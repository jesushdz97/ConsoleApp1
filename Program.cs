using ConsoleApp1.Service;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var searcherBeer = new SearcherBeer();
                var alcohol = searcherBeer.GetAlcohol("Corona");
                Console.WriteLine(alcohol);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
