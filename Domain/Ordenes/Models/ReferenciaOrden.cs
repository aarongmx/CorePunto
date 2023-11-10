using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorePuntoVenta.Domain.Support.Models;

namespace CorePuntoVenta.Domain.Ordenes.Models
{
    public class ReferenciaOrden : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Folio { get; set; }

        public string Prefijo { get; set; }
    }
}
