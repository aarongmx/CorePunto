using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Mappers
{
    [Mapper]
    public partial class ReferenciaOrdenMapper
    {
        public partial ReferenciaOrdenData ToDto(ReferenciaOrden entity);
        public partial ReferenciaOrden ToEntity(ReferenciaOrdenData dto);
    }
}
