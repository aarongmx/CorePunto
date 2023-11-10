using CorePuntoVenta.Domain.Direcciones.Models;
using CorePuntoVenta.Domain.Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Clientes.Models
{
    [Table("clientes")]
    public class Cliente : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Rfc {  get; set; }

        [Required]
        public string RazonSocial { get; set; }

        public string? NombreComercial { get; set; }

        public int DireccionId { get; set; }

        public Direccion? Direccion { get; set; }
    }
}
