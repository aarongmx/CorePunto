using CorePuntoVenta.Domain.Sucursales.Data;
using CorePuntoVenta.Domain.Sucursales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Sucursales.Actions
{
    public class StoreSucursalAction
    {
        public Sucursal? Execute(SucursalData sucursalData)
        {
            using (ApplicationDbContext context = new())
            {
                Sucursal sucursal = new()
                {
                    Nombre = sucursalData.Nombre,
                    Direccion = new()
                    {
                        CodigoPostal = sucursalData.Direccion!.CodigoPostal,
                        NumeroExterno = sucursalData.Direccion!.NumeroExterior,
                    }
                };
                context.Add(sucursal);
                context.SaveChanges();
                return sucursal;
            }
        }
    }
}
