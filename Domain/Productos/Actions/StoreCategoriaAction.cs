using CorePuntoVenta.Domain.Productos.Data;
using CorePuntoVenta.Domain.Productos.Mappers;
using CorePuntoVenta.Domain.Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Productos.Actions
{
    public class StoreCategoriaAction
    {
        private ApplicationDbContext _context;
        public StoreCategoriaAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public Categoria Execute(CategoriaData categoriaData)
        {
            var mapper = new CategoriaMapper();
            var categoria = mapper.ToEntity(categoriaData);
            _context.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }
    }
}
