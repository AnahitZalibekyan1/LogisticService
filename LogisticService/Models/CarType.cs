using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class CarType
    {
        public CarType(int id, string name, float coificent)
        {
            Id = id;
            Name = name;
            Coificent = coificent;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float Coificent {  get; set; }
    }
}
