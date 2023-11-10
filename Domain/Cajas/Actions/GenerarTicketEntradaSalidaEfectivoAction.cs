using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Support.Actions;
using ESC_POS_USB_NET.Enums;
using ESC_POS_USB_NET.Printer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class GenerarTicketEntradaSalidaEfectivoAction
    {
        private GenerarCabeceraTicketAction _ticket;

        public GenerarTicketEntradaSalidaEfectivoAction()
        {
            _ticket = new GenerarCabeceraTicketAction();
        }

        public void Execute(string impresora, ItemCajaData itemCajaData)
        {
            Printer ticket = _ticket.Execute(impresora);

            ticket.NewLines(3);

            if (itemCajaData.Movimiento == Enums.MovimientoCaja.INGRESO)
            {
                ticket.Append("MOVIMIENTO: INGRESO");
            }

            if (itemCajaData.Movimiento == Enums.MovimientoCaja.EGRESO)
            {
                ticket.Append("MOVIMIENTO: EGRESO");
            }

            string cajero = $"CAJERO: {itemCajaData?.Empleado?.Nombre} {itemCajaData?.Empleado?.ApellidoPaterno} {itemCajaData?.Empleado?.ApellidoMaterno}";

            string fecha = $"FECHA: {itemCajaData?.CreatedAt}";
            string motivo = $"MOTIVO: {itemCajaData?.Motivo}";

            string monto = "MONTO:".PadRight(28);
            monto += $"${itemCajaData?.Monto:N2}".PadLeft(14);

            ticket.Append(cajero);
            ticket.Append(fecha);
            ticket.NewLine();
            ticket.Append(motivo);
            ticket.NewLine();
            ticket.Separator();
            ticket.Append(monto);

            ticket.FullPaperCut();
            ticket.PrintDocument();
            ticket.OpenDrawer();
        }
    }
}
