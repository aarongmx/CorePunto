using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Cajas.Enums;
using CorePuntoVenta.Domain.Cajas.Models;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class AgregarEfectivoAction
    {
        private readonly ApplicationDbContext _context;

        public AgregarEfectivoAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public ItemCaja? Execute(int cajaId, ItemCajaData itemCajaData)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                ItemCaja itemCaja = null;
                var caja = _context.Cajas.Find(cajaId);
                if (caja != null)
                {
                    double monto = 0;
                    if (itemCajaData.Movimiento.Equals(MovimientoCaja.INGRESO))
                    {
                        caja.EfectivoDisponible += itemCajaData.Monto;
                        monto = itemCajaData.Monto;
                    }

                    if (itemCajaData.Movimiento.Equals(MovimientoCaja.EGRESO))
                    {
                        if(caja.EfectivoDisponible <= 0)
                        {
                            throw new Exception("No hay efectivo suficiente para");
                        }

                        caja.EfectivoDisponible -= itemCajaData.Monto;
                        monto = itemCajaData.Monto * -1;
                    }

                    itemCaja = new()
                    {
                        Movimiento = itemCajaData.Movimiento,
                        Monto = monto,
                        Motivo = itemCajaData.Motivo,
                        EmpleadoId = itemCajaData.EmpleadoId,
                        CajaId = cajaId,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    };
                    _context.Update(caja);
                    _context.Add(itemCaja);
                    _context.SaveChanges();
                }
                transaction.Commit();

                return itemCaja;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
