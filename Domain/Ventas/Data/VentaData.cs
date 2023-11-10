
using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Pagos.Data;
using CorePuntoVenta.Domain.Pagos.Models;
using CorePuntoVenta.Domain.Sucursales.Data;
using CorePuntoVenta.Domain.Support.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ventas.Data
{
    public class VentaData : AuditableData
    {
        public int? Id { get; set; }

        public double Total { get; set; }

        public double Subtotal { get; set; }

        public double Iva { get; set; }

        public int OrdenId { get; set; }

        public OrdenData? Orden { get; set; }

        public int SucursalId { get; set; }

        public SucursalData? Sucursal { get; set; }

        public ICollection<PagoData> Pagos { get; set; } = new List<PagoData>();
    }
}
