﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Ordenes.Data
{
    public class ReferenciaOrdenData
    {
        public int? Id { get; set; }

        public int Folio { get; set; }

        public string Prefijo { get; set; }
    }
}
