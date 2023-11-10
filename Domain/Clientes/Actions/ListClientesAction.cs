using CorePuntoVenta.Domain.Clientes.Data;
using CorePuntoVenta.Domain.Clientes.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Clientes.Actions
{
    public class ListClientesAction
    {
        private readonly ApplicationDbContext _context;

        public ListClientesAction() { }

        public ListClientesAction(ApplicationDbContext context) { _context = context; }

        public List<ClienteData> Execute()
        {
            var clienteMapper = new ClienteMapper();
            return _context.Clientes
                .Where(c => c.DeletedAt == null)
                .Select(cliente => clienteMapper.ToDto(cliente))
                .ToList();
        }
    }
}
