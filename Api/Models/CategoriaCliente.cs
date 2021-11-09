using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DBModels
{
    /// <summary>
    /// Tabla ClientCategory
    /// </summary>
    public class CategoriaCliente
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreCategoria { get; set; }
        public bool Activo { get; set; }
    }
}
