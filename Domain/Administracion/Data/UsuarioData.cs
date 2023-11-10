using CorePuntoVenta.Domain.Administracion.Models;
using CorePuntoVenta.Domain.Sucursales.Data;
using CorePuntoVenta.Domain.Sucursales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Administracion.Data
{
    public class UsuarioData
    {
        public int? Id { get; set; }

        public string? Nombre { get; set; }

        [EmailAddress]
        [Required]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }

        public int RolId { get; set; }

        public RolData? Rol { get; set; }

        public int SucursalId { get; set; }

        public SucursalData? Sucursal { get; set; }
    }
}