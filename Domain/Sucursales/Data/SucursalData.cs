using CorePuntoVenta.Domain.Direcciones.Data;
using CorePuntoVenta.Domain.Direcciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Sucursales.Data
{
    public class SucursalData
    {
        public int? Id { get; set; }

        public string Nombre { get; set; }

        public int DireccionId { get; set; }

        public DireccionData? Direccion { get; set; }
    }
}
