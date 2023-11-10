using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorePuntoVenta.Domain.Support.Models;

namespace CorePuntoVenta.Domain.Productos.Models
{
    public class Producto : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public double PrecioUnitario { get; set; }
        
        public int CategoriaId { get; set; }
        
        public Categoria? Categoria { get; set;}
    }
}
