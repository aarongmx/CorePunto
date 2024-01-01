using CorePuntoVenta.Domain.Direcciones.Data;
using CorePuntoVenta.Domain.Direcciones.Models;

namespace CorePuntoVenta.Domain.Direcciones.Actions
{
    public class StoreDireccionAction
    {
        private readonly ApplicationDbContext _context;
        public StoreDireccionAction() { }
        public StoreDireccionAction(ApplicationDbContext context) { _context = context; }


        public Direccion Execute(DireccionData direccionData)
        {
            Direccion direccion = new()
            {
                CodigoPostal = direccionData.CodigoPostal,
                NumeroExterno = direccionData.NumeroExterior,
                NumeroInterior = direccionData.NumeroInterior,
                Calle = direccionData.Calle,
                Colonia = direccionData.Colonia,
                Estado = direccionData.Estado,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            _context.Add(direccion);
            _context.SaveChanges();

            return direccion;
        }
    }
}
