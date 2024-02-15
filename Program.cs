using ConsoleApp1.Models;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] nombres = new string[] { "Heineken", "Budweiser", "BBD" };
            // List<Cerveza> cervezas = GenerarCervezas(nombres);

            // string JSON = JsonSerializer.Serialize(cervezas);
            // File.WriteAllText("json.text", JSON);

            string JSON = File.ReadAllText("json.text");
            var cervezas = JsonSerializer.Deserialize<List<Cerveza>>(JSON);

            if (cervezas == null) {
                Console.WriteLine("No se cargaron cervezas");
                return;
            }

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Name);
            }
        }

        static List<Cerveza> GenerarCervezas(string[] nombres) {
            List<Cerveza> cervezas = new();

            foreach (var nombre in nombres)
            {
                cervezas.Add(new Cerveza(nombre));
            }

            return cervezas;
        }
    }
}
