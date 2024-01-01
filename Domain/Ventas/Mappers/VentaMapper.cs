using CorePuntoVenta.Domain.Ventas.Data;
using CorePuntoVenta.Domain.Ventas.Models;
using Riok.Mapperly.Abstractions;

namespace CorePuntoVenta.Domain.Ventas.Mappers
{
    [Mapper]
    public partial class VentaMapper
    {
        public partial Venta ToEntity(VentaData ventaData);

        public partial VentaData ToDto(Venta venta);
    }
}
