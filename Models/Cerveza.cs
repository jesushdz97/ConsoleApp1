using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public Cerveza(string Name, int Cantidad = 350) : base(Name, Cantidad)
        {
        }

        public void MaximaCantidadRecomendada()
        {
            Console.WriteLine("Maximo recomendado ("+this.Name+"): 15 latas");
        }
    }
}
