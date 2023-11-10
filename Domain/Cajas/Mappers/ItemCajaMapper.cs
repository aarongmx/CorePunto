using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Cajas.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Mappers
{
    [Mapper]
    public partial class ItemCajaMapper
    {
        public partial ItemCaja ToEntity(ItemCajaData itemCajaData);

        public partial ItemCajaData ToDto(ItemCaja itemCaja);
    }
}
