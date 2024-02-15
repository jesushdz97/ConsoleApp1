using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public Vino(string Name, int Cantidad) : base(Name, Cantidad)
        {
        }

        public void MaximaCantidadRecomendada()
        {
            Console.WriteLine("Maximo recomendado ("+this.Name+"): 1 botella");
        }
    }
}
