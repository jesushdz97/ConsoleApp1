using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1.Models
{
    internal class Damage
    { 
        public int DamagesId { get; set; }
        public string Description { get; set; }

        public Damage(int damagesId, string description)
        {
            DamagesId = damagesId;
            Description = description;
        }

        public Damage(string description)
        {
            Description = description;
        }
    }
}
