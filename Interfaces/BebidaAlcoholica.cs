using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    internal interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaximaCantidadRecomendada();
    }
}
