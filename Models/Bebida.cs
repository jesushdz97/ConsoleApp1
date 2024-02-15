using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Bebida
    {
        public string Name { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string Name, int Cantidad) { 
            this.Name = Name;
            this.Cantidad = Cantidad;
        }

        public void Beber(int Cantidad) { 
            this.Cantidad -= Cantidad;
        }
    }
}
