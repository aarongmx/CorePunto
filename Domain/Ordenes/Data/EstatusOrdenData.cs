using CorePuntoVenta.Domain.Support.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Data
{
    public class EstatusOrdenData : AuditableData
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
    }
}
