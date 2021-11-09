using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Empleado
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string IdTipoEmpleado { get; set; }

        public virtual TipoEmpleado TipoEmpleado { get; set; }

    }
}
