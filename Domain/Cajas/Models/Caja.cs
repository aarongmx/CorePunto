using CorePuntoVenta.Domain.Empleados.Models;
using CorePuntoVenta.Domain.Sucursales.Models;
using CorePuntoVenta.Domain.Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Models
{
    public class Caja : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NumeroCaja { get; set; }

        public double EfectivoDisponible { get; set; }

        public int SucursalId { get; set; }

        public Sucursal? Sucursal { get; set; }

        public ICollection<ItemCaja> Items { get; set; } = new List<ItemCaja>();

        public string Ip { get; set; }

        public string Hostname { get; set; }
    }
}
