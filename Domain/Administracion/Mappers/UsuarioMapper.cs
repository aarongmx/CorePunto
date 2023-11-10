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
    public partial class UsuarioMapper
    {
        public partial Usuario ToEntity(UsuarioData data);
        public partial UsuarioData ToDto(Usuario usuario);
    }
}
