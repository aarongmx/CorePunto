using CorePuntoVenta.Domain.Ordenes.Data;
using CorePuntoVenta.Domain.Ordenes.Mappers;
using CorePuntoVenta.Domain.Ordenes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Actions
{
    public class StoreOrdenAction
    {
        public Orden? Execute(OrdenData data)
        {
            using ApplicationDbContext context = new();
            using var transaction = context.Database.BeginTransaction();
            var ordenMapper = new OrdenMapper();
            var itemOrdenMapper = new ItemOrdenMapper();
            var referenciaOrdenMapper = new ReferenciaOrdenMapper();

            try
            {
                var referencia = new GenerarReferenciaAction(context).Execute();
                var folio = referencia.Folio += 1;
                data.Referencia = "ORD-" + folio;
                data.CajaId = 1;

                var orden = ordenMapper.ToEntity(data);

                if (data.ItemsOrden != null)
                {
                    var items = data.ItemsOrden.Select(itemOrdenMapper.ToEntity).ToList();

                    orden.ItemsOrden = items;
                }

                context.Update(referencia);
                context.Add(orden);
                context.SaveChanges();

                transaction.Commit();
                return orden;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
