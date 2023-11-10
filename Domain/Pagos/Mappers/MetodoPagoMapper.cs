using CorePuntoVenta.Domain.Pagos.Data;
using CorePuntoVenta.Domain.Pagos.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Pagos.Mappers
{
    [Mapper]
    public partial class MetodoPagoMapper
    {
        public partial MetodoPago ToEntity(MetodoPagoData metodoPagoData);

        public partial MetodoPagoData ToDto(MetodoPago metodoPago);
    }
}
