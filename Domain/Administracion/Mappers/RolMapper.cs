using CorePuntoVenta.Domain.Administracion.Data;
using CorePuntoVenta.Domain.Administracion.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Administracion.Mappers
{
    [Mapper]
    public partial class RolMapper
    {
        public partial Rol ToEntity(RolData rolData);
        public partial RolData ToDto(Rol rol);
    }
}
