using CorePuntoVenta.Domain.Cajas.Models;
using CorePuntoVenta.Domain.Clientes.Models;
using CorePuntoVenta.Domain.Support.Models;
using CorePuntoVenta.Domain.Ventas.Models;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Pagos.Models
{
    [Table("pagos")]
    public class Pago : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public double MontoRecibido { get; set; }
        
        public double Cambio { get; set; }
        
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public int MetodoPagoId { get; set; }
        
        public MetodoPago? MetodoPago { get; set; }

        public int VentaId { get; set; }
        
        public Venta? Venta { get; set; }

        public int CajaId { get; set; }

        public Caja? Caja { get; set; }
    }
}
