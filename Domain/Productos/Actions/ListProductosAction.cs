using CorePuntoVenta.Domain.Productos.Data;
using CorePuntoVenta.Domain.Productos.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Productos.Actions
{
    public class ListProductosAction
    {
        private readonly ApplicationDbContext _context;
        public ListProductosAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProductoData> Execute()
        {
            ProductoMapper mapper = new();
            return _context.Productos.Include(p => p.Categoria).Select(producto => mapper.ToDto(producto)).AsSplitQuery().ToList();
        }

    }
}
