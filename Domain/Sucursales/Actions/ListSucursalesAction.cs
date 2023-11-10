using CorePuntoVenta.Domain.Sucursales.Data;
using CorePuntoVenta.Domain.Sucursales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
