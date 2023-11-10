using BCrypt.Net;
using CorePuntoVenta.Domain.Administracion.Data;
using CorePuntoVenta.Domain.Administracion.Mappers;
using CorePuntoVenta.Domain.Administracion.Models;
using CorePuntoVenta.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Administracion.Actions
{
    public class LoginAction
    {
        private ApplicationDbContext _context;

        public LoginAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public Session? Execute(UsuarioData usuarioData)
        {
            Session? session = null;
            Usuario usuario = _context.Usuarios
                .Where(u => u.Correo.ToLower().Equals(usuarioData.Correo.ToLower()))
                .Single();
            bool isVerify = BCrypt.Net.BCrypt.Verify(usuarioData.Password, usuario.Password);

            if (isVerify)
            {
                var mapper = new UsuarioMapper();
                var data = mapper.ToDto(usuario);
                session = Session.GetInstance(data);
            }

            return session;
        }
    }
}
