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
    public partial class CorteMapper
    {
        public partial Corte ToEntity(CorteData corteData);

        public partial CorteData ToDto(Corte corte);
    }
}
