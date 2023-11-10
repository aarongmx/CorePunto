using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class BuscarOrdenesPendientesAction
    {
        private ApplicationDbContext _context;
        private readonly OrdenMapper _mapper;
        public BuscarOrdenesPendientesAction(ApplicationDbContext context)
        {
            _context = context;
            _mapper = new OrdenMapper();
        }

        public List<OrdenData> Execute(string search = "")
        {
            return _context.Ordenes
                .Where(o => o.EstatusOrdenId == 1)
                .Where(o => o.Referencia.Contains(search))
                .Select(o => _mapper.ToDto(o))
                .ToList();
        }
    }
}
