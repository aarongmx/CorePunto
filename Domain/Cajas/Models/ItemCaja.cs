using CorePuntoVenta.Domain.Cajas.Enums;
using CorePuntoVenta.Domain.Empleados.Models;
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
    public class ItemCaja : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public MovimientoCaja Movimiento { get; set; }

        public double Monto { get; set; }

        public string? Motivo {  get; set; }

        public int EmpleadoId { get; set; }

        public Empleado? Empleado { get; set; }

        public int CajaId { get; set; }

        public Caja? Caja { get; set; }
    }
}
