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
    public partial class ItemOrdenMapper
    {
        public partial ItemOrdenData ToDto(ItemOrden itemOrden);

        public partial ItemOrden ToEntity(ItemOrdenData itemOrdenData);
    }
}
