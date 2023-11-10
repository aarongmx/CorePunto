using CorePuntoVenta.Domain.Productos.Models;
using CorePuntoVenta.Domain.Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Models
{
    public class ItemOrden : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double PrecioUnitario { get; set; }

        public double Total { get; set; }

        public double Kilos { get; set; }

        public int ProductoId { get; set; }

        public Producto? Producto { get; set; } = null!;

        public int OrdenId { get; set; }
        
        public Orden? Orden { get; set; } = null!;
    }
}
