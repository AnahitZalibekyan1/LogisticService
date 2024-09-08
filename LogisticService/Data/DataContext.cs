﻿using LogisticService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Data
{
    internal class DataContext: DbContext
    {
        public DbSet<Direction> Directions { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<CrushedCar> CrushedCars { get; set; }
        public DbSet<Container> Container { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Calculation> Calculation { get; set; }
        public DbSet<LogisticModel> LogisticModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LogisticServiceDB;Integrated Security=True;Encrypt=False");
        }
    }
}
