using CorePuntoVenta.Domain.Ordenes.Models;
using CorePuntoVenta.Domain.Productos.Data;
using CorePuntoVenta.Domain.Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Data
{
    public class ItemOrdenData
    {
        public int? Id { get; set; }

        public double PrecioUnitario { get; set; }

        public double Total { get; set; }

        public double Kilos { get; set; }

        public int ProductoId { get; set; }

        public ProductoData? Producto { get; set; }

        public int OrdenId { get; set; }

        public OrdenData? Orden { get; set; }
    }
}
