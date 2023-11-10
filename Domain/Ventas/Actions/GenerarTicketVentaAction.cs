using CorePuntoVenta.Domain.Pagos.Data;
using CorePuntoVenta.Domain.Support.Actions;
using CorePuntoVenta.Domain.Ventas.Data;
using ESC_POS_USB_NET.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ventas.Actions
{
    public class GenerarTicketVentaAction
    {
        private readonly GenerarCabeceraTicketAction _ticket;
        public GenerarTicketVentaAction() { 
            _ticket = new GenerarCabeceraTicketAction();
        }

        public void Execute(string impresora, PagoData pagoData)
        {
            Printer ticket = _ticket.Execute(impresora);

            string efectivo = $"EFECTIVO: {pagoData?.Venta?.Total}";
            string cambio = $"CAMBIO: {pagoData?.Cambio}";

            ticket.Append(efectivo);
            ticket.Append(cambio);

            ticket.FullPaperCut();
            ticket.PrintDocument();
            ticket.OpenDrawer();
        }
    }
}
