using CorePuntoVenta.Domain.Clientes.Data;
using CorePuntoVenta.Domain.Clientes.Models;
using CorePuntoVenta.Domain.Direcciones.Actions;
using CorePuntoVenta.Domain.Direcciones.Data;
using CorePuntoVenta.Domain.Direcciones.Models;

namespace CorePuntoVenta.Domain.Clientes.Actions
{
    public class StoreClienteAction
    {
        private readonly ApplicationDbContext _context;

        public StoreClienteAction() { }
        public StoreClienteAction(ApplicationDbContext context) { _context = context; }

        public Cliente? Execute(ClienteData clienteData, DireccionData direccionData)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                Direccion direccion = (new StoreDireccionAction(_context)).Execute(direccionData);

                Cliente cliente = new()
                {
                    NombreComercial = clienteData.NombreComercial,
                    Rfc = clienteData.Rfc,
                    RazonSocial = clienteData.RazonSocial,
                    DireccionId = direccion.Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                _context.Add(cliente);
                _context.SaveChanges();

                transaction.Commit();

                return cliente;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }
    }
}
