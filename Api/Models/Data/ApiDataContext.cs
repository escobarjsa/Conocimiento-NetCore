using Api.DBModels;
using Api.Models.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.Data
{
    public class ApiDataContext : DbContext
    {
        public ApiDataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CategoriaCliente> CategoriaClientes { get; set; }

        public DbSet<TipoEmpleado> TipoEmpleado { get; set; }

        public DbSet<Empleado> Empleado { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TipoEmpleadoConfig.SetEntityBuilder(modelBuilder.Entity<TipoEmpleado>());
            EmpleadoConfig.SetEntityBuilder(modelBuilder.Entity<Empleado>());
        }

    }
}
