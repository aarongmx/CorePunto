using CorePuntoVenta.Domain.Productos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Productos.Actions
{
    public class ListCategoriasAction
    {
        private readonly ApplicationDbContext _context;

        public ListCategoriasAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CategoriaData> Execute()
        {
            using ApplicationDbContext context = new();
            return context.Categorias
                .Select(categoria => new CategoriaData() { 
                    Id = categoria.Id, 
                    Nombre = categoria.Nombre,
                })
                .ToList();
        }
    }
}
