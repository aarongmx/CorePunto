using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Cajas.Models;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class StoreCorteCajaAction
    {
        private ApplicationDbContext _context;

        public StoreCorteCajaAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Execute(CorteData corteData)
        {
            Corte corte = new Corte()
            {
                CajaId = corteData.CajaId,
                MontoCorte = corteData.MontoCorte,
                MontoEnCaja = corteData.MontoEnCaja,
                MontoInicial = corteData.MontoInicial,
                CreatedAt = DateTime.UtcNow,
                Fecha = corteData.Fecha,
            };

            Caja? caja = _context.Cajas.SingleOrDefault(c => c.Id == corteData.CajaId);

            if (caja != null)
            {
                caja.EfectivoDisponible = corteData.MontoEnCaja;
            }

            _context.Add(corte);
            _context.SaveChangesAsync();
        }
    }
}
