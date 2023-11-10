using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorePuntoVenta.Domain.Ordenes.Models;
using CorePuntoVenta.Domain.Sucursales.Models;
using CorePuntoVenta.Domain.Support.Models;
using CorePuntoVenta.Domain.Pagos.Models;

namespace CorePuntoVenta.Domain.Ventas.Models
{
    public class Venta : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Subtotal { get; set; }

        public double Total { get; set; }

        public double Iva { get; set; }

        public int OrdenId { get; set; }

        public Orden? Orden { get; set; }

        public int SucursalId { get; set; }

        public Sucursal? Sucursal { get; set; }

        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
