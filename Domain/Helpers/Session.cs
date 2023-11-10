using CorePuntoVenta.Domain.Administracion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Helpers
{
    public class Session
    {
        private Session() { }

        private static Session _instance;

        private static readonly object _lock = new object();
        
        public UsuarioData Value { get; private set; }
        public bool LoggedIn { get; private set; } = false;

        public static Session GetInstance(UsuarioData usuarioData)
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Session
                        {
                            Value = usuarioData,
                            LoggedIn = true
                        };
                    }
                }
            }
            return _instance;
        }
    }
}
