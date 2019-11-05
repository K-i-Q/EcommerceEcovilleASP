using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UsuarioDAO : IRepository<Usuario>
    {
        private readonly Context _context;
        public UsuarioDAO(Context context)
        {
            _context = context;
        }
        public Usuario BuscarPorId(long? id) => _context.Usuarios.Find(id);

        public bool Cadastrar(Usuario objeto)
        {
            if (objeto != null && BuscarPorEmail(objeto) == null)
            {
                _context.Usuarios.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario BuscarPorEmail(Usuario usuario) => _context.Usuarios.FirstOrDefault(x => x.Email.Equals(usuario.Email));

        public List<Usuario> ListarTodos() => _context.Usuarios.ToList();

        public bool EditarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ExisteUsuario(long? id) => _context.Usuarios.Find(id) != null;

        public void DeletarUsuario(long? id)
        {
            _context.Usuarios.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}
