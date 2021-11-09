using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.EntityConfig
{
    public class EmpleadoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Empleado> entityBuilder)
        {
            entityBuilder.ToTable("EMPLEADO");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.Property(x => x.Nombre).HasColumnName("NOMBRE_PRUEBA");
            //entityBuilder.Property(x => x.Id).ValueGeneratedOnAdd();
            //entityBuilder.HasKey(x => new { x.Id, x.Nombre }); // ejemplo con llave primaria compuesta
            entityBuilder.HasOne(x => x.TipoEmpleado).WithMany(x => x.Empleados).HasForeignKey(x => x.IdTipoEmpleado);
        }
    }
}
