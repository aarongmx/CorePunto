using CorePuntoVenta.Domain.Ordenes.Models;
using CorePuntoVenta.Domain.Pagos.Models;
using CorePuntoVenta.Domain.Sucursales.Models;
using CorePuntoVenta.Domain.Support.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorePuntoVenta.Domain.Ventas.Models
{
    [Table("ventas")]
    public class Venta : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("subtotal")]
        public double Subtotal { get; set; }

        [Column("total")]
        public double Total { get; set; }

        [Column("iva")]
        public double Iva { get; set; }

        [Column("orden_id")]
        public int OrdenId { get; set; }

        public Orden? Orden { get; set; }

        [Column("sucursal_id")]
        public int SucursalId { get; set; }

        public Sucursal? Sucursal { get; set; }

        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
