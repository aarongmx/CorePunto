using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Actions
{
    public class ActualizarReferenciaAction
    {
        private readonly ApplicationDbContext _context;

        public ActualizarReferenciaAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Execute(ReferenciaOrdenData referenciaOrdenData)
        {
            var mapper = new ReferenciaOrdenMapper();
            var referencia = mapper.ToEntity(referenciaOrdenData);
            _context.Add(referencia);
            _context.SaveChanges();
        }
    }
}
