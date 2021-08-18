using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPrueba.Context
{
    public class AppDbContext :Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<historial> prueba_admision { get; set; }
    }
}
