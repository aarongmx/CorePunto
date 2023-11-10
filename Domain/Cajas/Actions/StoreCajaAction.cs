using CorePuntoVenta.Domain.Cajas.Data;
using CorePuntoVenta.Domain.Cajas.Mappers;
using CorePuntoVenta.Domain.Cajas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Cajas.Actions
{
    public class StoreCajaAction
    {
        private readonly ApplicationDbContext _context;
        private readonly CajaMapper _mapper;

        public StoreCajaAction(ApplicationDbContext context)
        {
            _context = context;
            _mapper = new();
        }

        public Caja? Execute(CajaData cajaData)
        {
            string hostName = string.Empty;
            hostName = Dns.GetHostName();
            IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);

            IPAddress? ip = ipHostEntry.AddressList.ToList().Find(ip => ip.AddressFamily is System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString().StartsWith("192.168"));

            cajaData.Ip = ip.ToString();
            cajaData.Hostname = hostName;

            Caja caja = _mapper.ToEntity(cajaData);
            _context.Add(caja);
            _context.SaveChanges();
            return caja;
        }
    }
}
