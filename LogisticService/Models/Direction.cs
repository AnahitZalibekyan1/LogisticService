using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class Direction
    {
        public Direction(int id, float price, string from, string to, float distance)
        {
            Id = id;
            Price = price;
            From = from;
            To = to;
            Distance = distance;
        }

        public int Id { get; set; }
        public float Price { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public float Distance { get; set; }
    }
}
