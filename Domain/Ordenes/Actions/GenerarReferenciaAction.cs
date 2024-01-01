using CorePuntoVenta.Domain.Ordenes.Mappers;
using CorePuntoVenta.Domain.Ordenes.Models;

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
