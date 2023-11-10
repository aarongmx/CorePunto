using CorePuntoVenta.Domain.Productos.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorePuntoVenta.Domain.Clientes.Data
{
    public class ClienteData
    {
        public int? Id { get; set; }

        [Required]
        [RegularExpression(@"^([A-ZÑa-zñ]|&){3,4}[0-9]{2}(0[1-9]|1[0-2])([12][0-9]|0[1-9]|3[01])[A-Z0-9]{3}$")]
        public string Rfc { get; set; }

        [Required]
        public string RazonSocial { get; set; }

        public string? NombreComercial { get; set; }

        public override string ToString()
        {
            return $"{Rfc} {NombreComercial}";
        }
    }
}
