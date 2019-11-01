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
            if (objeto != null)
            {
                _context.Usuarios.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Usuario> ListarTodos() => _context.Usuarios.ToList();
    }
}
