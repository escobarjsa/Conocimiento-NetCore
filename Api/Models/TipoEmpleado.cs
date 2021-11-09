using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class TipoEmpleado
    {
        public string Id { get; set; }

        public string RolEmpleado { get; set; }

        public bool Activo { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

    }
}
