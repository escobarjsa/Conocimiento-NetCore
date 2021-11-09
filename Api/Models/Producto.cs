using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }
        //[DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }
        public int Stock { get; set; }
    }
}
