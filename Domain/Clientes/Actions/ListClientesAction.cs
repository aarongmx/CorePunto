using CorePuntoVenta.Domain.Clientes.Data;
using CorePuntoVenta.Domain.Clientes.Mappers;

namespace CorePuntoVenta.Domain.Clientes.Actions
{
    public class ListClientesAction(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public List<ClienteData> Execute()
        {
            var clienteMapper = new ClienteMapper();
            return [
                .. _context.Clientes
                .Where(c => c.DeletedAt == null)
                .Select(cliente => clienteMapper.ToDto(cliente))
            ];
        }
    }
}
