﻿using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Clientes.Data;
using CorePuntoVenta.Domain.Ventas.Data;

namespace CorePuntoVenta.Domain.Pagos.Data
{
    public class PagoData
    {
        public int? Id { get; set; }

        public double MontoRecibido { get; set; }

        public double Cambio { get; set; }

        public int ClienteId { get; set; }

        public ClienteData? Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public int MetodoPagoId { get; set; }

        public MetodoPagoData? MetodoPago { get; set; }

        public int VentaId { get; set; }

        public VentaData? Venta { get; set; }

        public int CajaId { get; set; }

        public CajaData? Caja { get; set; }
    }
}
