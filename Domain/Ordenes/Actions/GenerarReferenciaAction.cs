using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Mappers;
using CorePuntoVenta.Domain.Ordenes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Actions
{
    public class GenerarReferenciaAction
    {
        private ApplicationDbContext _context;

        public GenerarReferenciaAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public ReferenciaOrden Execute()
        {
            var mapper = new ReferenciaOrdenMapper();
            var referencia = _context.RefereciasOrden.FirstOrDefault();

            if (referencia is null)
            {
                referencia = new ReferenciaOrden()
                {
                    Folio = 0,
                    Prefijo = "ORD",
                };

                _context.Add(referencia);
                _context.SaveChanges();
            }

            return referencia;
        }
    }
}
