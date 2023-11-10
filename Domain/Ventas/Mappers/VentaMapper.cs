using CorePuntoVenta.Domain.Ventas.Data;
using CorePuntoVenta.Domain.Ventas.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ventas.Mappers
{
    [Mapper]
    public partial class VentaMapper
    {
        public partial Venta ToEntity(VentaData ventaData);

        public partial VentaData ToDto(Venta venta);
    }
}
