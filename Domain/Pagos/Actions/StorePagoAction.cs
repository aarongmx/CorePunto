using CorePuntoVenta.Domain.Pagos.Data;
using CorePuntoVenta.Domain.Pagos.Mappers;
using CorePuntoVenta.Domain.Pagos.Models;

namespace CorePuntoVenta.Domain.Pagos.Actions
{
    public class StorePagoAction(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;
        private readonly PagoMapper _mapper = new();

        public Pago? Execute(PagoData pagoData)
        {
            Pago pago = _mapper.ToEntity(pagoData);
            _context.Add(pago);
            _context.SaveChanges();
            return pago;
        }
    }
}
