using CorePuntoVenta.Domain.Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Direcciones.Models
{
    [Table("direcciones")]
    public class Direccion : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Calle {  get; set; }

        public string NumeroExterno { get; set; }

        public string? NumeroInterior { get; set; }

        public string CodigoPostal { get; set; }

        public string? Colonia { get; set; }

        public string? Estado { get; set; }
    }
}
