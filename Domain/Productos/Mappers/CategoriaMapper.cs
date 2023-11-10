using CorePuntoVenta.Domain.Productos.Data;
using CorePuntoVenta.Domain.Productos.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Productos.Mappers
{
    [Mapper]
    public partial class CategoriaMapper
    {
        public partial Categoria ToEntity(CategoriaData categoriaData);

        public partial CategoriaData ToDto(Categoria categoria);
    }
}
