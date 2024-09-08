using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class Calculation
    {
        public CarType CarType1 { get; set; }
        public Container Container1 { get; set; }
        public CrushedCar CrushedCar1 { get; set; }
        public Direction Direction1 { get; set; }
        public State State1 { get; set; }

        public float Calculate()
        {
            var x = CarType1.Coificent * Container1.Coificent * CrushedCar1.Coificent
                * Direction1.Price * State1.Coificent;
            return x;
        }
    }
}
