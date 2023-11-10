using CorePuntoVenta.Domain.Ventas.Data;
using CorePuntoVenta.Domain.Ventas.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ventas.Actions
{
    public class ListVentasAction
    {
        private ApplicationDbContext _context;
        private VentaMapper _mapper;


        public ListVentasAction(ApplicationDbContext context)
        {
            _context = context;
            _mapper = new();
        }

        public List<VentaData> Execute()
        {
            return _context.Ventas
                .Include(v => v.Orden)
                .ThenInclude(o => o.Cliente)
                .Include(v => v.Orden)
                .ThenInclude(o => o.Empleado)
                .Select(venta => _mapper.ToDto(venta))
                .ToList();
        }
    }
}
