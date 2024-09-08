using LogisticService.Data;
using LogisticService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class LogisticModel
    {
        private readonly Repository<Calculation, int, DataContext> _repository;
        private readonly Repository<CarType, int, DataContext> _carType;
        private readonly Repository<Container, int, DataContext> _container;
        private readonly Repository<CrushedCar, int, DataContext> _crushedCar;
        private readonly Repository<Direction, int, DataContext> _direction;
        private readonly Repository<State, int, DataContext> _state;
    }
}
