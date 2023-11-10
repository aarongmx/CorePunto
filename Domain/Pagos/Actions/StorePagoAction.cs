using CorePuntoVenta.Domain.Pagos.Data;
using CorePuntoVenta.Domain.Pagos.Mappers;
using CorePuntoVenta.Domain.Pagos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Pagos.Actions
{
    public class StorePagoAction
    {
        private ApplicationDbContext _context;
        private PagoMapper _mapper;

        public StorePagoAction(ApplicationDbContext context)
        {
            _context = context;
            _mapper = new PagoMapper();
        }

        public Pago? Execute(PagoData pagoData)
        {
            Pago pago = _mapper.ToEntity(pagoData);
            _context.Add(pago);
            _context.SaveChanges();
            return pago;
        }
    }
}
