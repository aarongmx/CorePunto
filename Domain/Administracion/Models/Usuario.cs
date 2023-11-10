using CorePuntoVenta.Domain.Sucursales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Administracion.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string? Nombre { get; set; }
        
        public string Correo { get; set; }
        
        public string Password { get; set; }

        public string? Token { get; set; }

        public int RolId { get; set; }

        public Rol? Rol { get; set; }

        public int SucursalId { get; set; }

        public Sucursal? Sucursal { get; set; }
    }
}
