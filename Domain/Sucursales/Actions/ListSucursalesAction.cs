using CorePuntoVenta.Domain.Sucursales.Data;

namespace CorePuntoVenta.Domain.Sucursales.Actions
{
    public class ListSucursalesAction
    {
        public List<SucursalData> Execute()
        {
            using (ApplicationDbContext context = new())
            {
                return context.Sucursales.Select(sucursal => new SucursalData
                {
                    Id = sucursal.Id,
                    Nombre = sucursal.Nombre,
                    DireccionId = sucursal.DireccionId,
                }).ToList();
            }
        }
    }
}
