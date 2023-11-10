using CorePuntoVenta.Domain.Sucursales.Data;
using CorePuntoVenta.Domain.Sucursales.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Sucursales.Mappers
{
    [Mapper]
    public partial class SucursalMapper
    {
        public partial Sucursal ToEntity(SucursalData sucursalData);

        public partial SucursalData ToDto(Sucursal sucursal);
    }
}
