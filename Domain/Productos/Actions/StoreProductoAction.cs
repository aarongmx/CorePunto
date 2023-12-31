﻿using CorePuntoVenta.Domain.Productos.Data;
using CorePuntoVenta.Domain.Productos.Models;

namespace CorePuntoVenta.Domain.Productos.Actions
{
    public class StoreProductoAction
    {
        private readonly ApplicationDbContext _context;

        public StoreProductoAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public Producto Execute(ProductoData data)
        {

            Producto producto = new()
            {
                CategoriaId = data.CategoriaId,
                Nombre = data.Nombre,
                PrecioUnitario = data.PrecioUnitario,
            };
            _context.Add(producto);
            _context.SaveChanges();

            return producto;
        }
    }
}
