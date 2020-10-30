﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace AeroApi.Model
{
    public class AeroContext : DbContext
    {
        public DbSet<Local> Locais { get; set; }

       public  DbSet<Reserva> Reservas { get; set; }

        public DbSet<Voo> Voos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=aero_db;user=root;password=root");
        }

    }
}
