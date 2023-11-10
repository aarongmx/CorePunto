using CorePuntoVenta.Domain.Cajas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class CalcularCorteCajaAction
    {
        public static double Execute(Caja caja) => caja.Items.Sum(item => item.Monto);
    }
}
