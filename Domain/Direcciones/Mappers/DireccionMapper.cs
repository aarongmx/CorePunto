using CorePuntoVenta.Domain.Direcciones.Data;
using CorePuntoVenta.Domain.Direcciones.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Direcciones.Mappers
{
    [Mapper]
    public partial class DireccionMapper
    {
        public partial Direccion ToEntity(DireccionData direccionData);

        public partial DireccionData ToDto(Direccion direccion);
    }
}
