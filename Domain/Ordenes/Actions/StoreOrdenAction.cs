using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Mappers;
using CorePuntoVenta.Domain.Ordenes.Models;

namespace CorePuntoVenta.Domain.Ordenes.Actions
{
    public class StoreOrdenAction(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public Orden? Execute(OrdenData data)
        {
            using var transaction = _context.Database.BeginTransaction();
            var ordenMapper = new OrdenMapper();
            var itemOrdenMapper = new ItemOrdenMapper();
            var referenciaOrdenMapper = new ReferenciaOrdenMapper();

            try
            {
                var referencia = new GenerarReferenciaAction(_context).Execute();
                var folio = referencia.Folio += 1;
                data.Referencia = "ORD-" + folio;
                data.CajaId = 1;

                var orden = ordenMapper.ToEntity(data);

                if (data.ItemsOrden != null)
                {
                    var items = data.ItemsOrden.Select(itemOrdenMapper.ToEntity).ToList();

                    orden.ItemsOrden = items;
                }

                _context.Update(referencia);
                _context.Add(orden);
                _context.SaveChanges();

                transaction.Commit();
                return orden;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
