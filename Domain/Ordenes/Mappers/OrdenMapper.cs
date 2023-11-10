using CorePuntoVenta.Domain.Ordenes.Models;
using CorePuntoVenta.Domain.Ordenes.Data;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Mappers
{
    [Mapper]
    public partial class OrdenMapper
    {
        public partial OrdenData ToDto(Orden orden);

        public partial Orden ToEntity(OrdenData dto);
    }
}
