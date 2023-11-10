using CorePuntoVenta.Domain.Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Models
{
    public class Corte : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public double MontoInicial { get; set; }

        public double MontoEnCaja { get; set; }
        
        public double MontoCorte { get; set; }

        public int CajaId { get; set; }

        public Caja? Caja { get; set; }
    }
}
