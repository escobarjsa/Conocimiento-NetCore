using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.EntityConfig
{
    public class TipoEmpleadoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<TipoEmpleado> entityBuilder)
        {
            entityBuilder.ToTable("TIPO_EMPLEADO");
            entityBuilder.HasKey(x => x.Id);
            //entityBuilder.HasKey(x => new { x.Id, x.Nombre }); // ejemplo con llave primaria 

        }
    }
}
