using CorePuntoVenta.Domain.Administracion.Data;
using CorePuntoVenta.Domain.Administracion.Mappers;
using CorePuntoVenta.Domain.Administracion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CorePuntoVenta.Domain.Administracion.Actions
{
    public class CrearUsuarioAction
    {
        private readonly ApplicationDbContext _context;
        private readonly UsuarioMapper _mapper;
        private const int WORK_FACTOR = 12;

        public CrearUsuarioAction(ApplicationDbContext context)
        {
            _context = context;
            _mapper = new UsuarioMapper();
        }


        public void Execute(UsuarioData usuarioData)
        {
            ValidationContext validationContext = new(usuarioData, null, null);
            List<ValidationResult> errors = new();
            bool isValid = Validator.TryValidateObject(usuarioData, validationContext, errors, true);
            Console.WriteLine(isValid);

            if (errors.Count > 0) return;

            Usuario usuario = _mapper.ToEntity(usuarioData);
            usuario.Password = BCrypt.Net.BCrypt.HashPassword(usuarioData.Password, workFactor: WORK_FACTOR);

            _context.Add(usuario);
            _context.SaveChanges();
        }
    }
}
