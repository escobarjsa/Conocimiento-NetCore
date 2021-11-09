using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DBModels
{
    /// <summary>
    /// Tabla Clients
    /// </summary>
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(500)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(700)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroCelular { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual CategoriaCliente CategoriaCliente { get; set; }

    }
}
