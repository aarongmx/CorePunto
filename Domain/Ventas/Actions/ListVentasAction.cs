using CorePuntoVenta.Domain.Ventas.Data;
using CorePuntoVenta.Domain.Ventas.Mappers;
using Microsoft.EntityFrameworkCore;

namespace CorePuntoVenta.Domain.Ventas.Actions
{
    public class ListVentasAction(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;
        private readonly VentaMapper _mapper = new();

        public List<VentaData> Execute()
        {
            return
            [
                .. _context.Ventas
                                .Include(v => v.Orden)
                                .ThenInclude(o => o.Cliente)
                                .Include(v => v.Orden)
                                .ThenInclude(o => o.Empleado)
                                .Select(venta => _mapper.ToDto(venta))
,
            ];
        }
    }
}
