using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CategoriaDAO : IRepository<Categoria>
    {
        private readonly Context _context;

        public CategoriaDAO(Context context)
        {
            _context = context;
        }


        public void RemoverCategoria(Categoria c)
        {
            _context.Categorias.Remove(c);
            _context.SaveChanges();
        }
        public void EditarCategoria(Categoria c)
        {
            _context.Update(c);
            _context.SaveChanges();
        }

        public Categoria BuscarPorId(long? id) => _context.Categorias.Find(id);
        public bool ExisteCategoria(string nome) => _context.Categorias.FirstOrDefault(x => x.Nome.Equals(nome)) != null;
        public bool ExisteCategoria(long? id) => _context.Categorias.Any(x => x.CategoriaId == id);


        public bool Cadastrar(Categoria objeto)
        {
            if (objeto != null)
            {
                _context.Categorias.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Categoria> ListarTodos() => _context.Categorias.ToList();
    }
}
