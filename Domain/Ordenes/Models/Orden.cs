using CorePuntoVenta.Domain.Cajas.Models;
using CorePuntoVenta.Domain.Clientes.Models;
using CorePuntoVenta.Domain.Empleados.Models;
using CorePuntoVenta.Domain.Support.Models;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Models
{
    [Table("ordenes")]
    public class Orden : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public double Kilos {  get; set; }

        public double Total { get; set; }

        public ICollection<ItemOrden> ItemsOrden { get; set; } = new List<ItemOrden>();

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        public int EmpleadoId { get; set; }

        public Empleado? Empleado { get; set; }

        public string Referencia { get; set; }

        public int CajaId { get; set; }

        public Caja? Caja { get; set; }

        public int EstatusOrdenId { get; set; }

        public EstatusOrden? EstatusOrden { get; set; }
    }
}
