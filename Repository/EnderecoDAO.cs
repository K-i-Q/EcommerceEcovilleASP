using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class EnderecoDAO : IRepository<Endereco>
    {
        private readonly Context _context;
        public EnderecoDAO(Context context)
        {
            _context = context;
        }

        public Endereco BuscarPorId(long? id) => _context.Enderecos.Find(id);

        public bool Cadastrar(Endereco objeto)
        {
            if (objeto != null)
            {
                _context.Enderecos.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Endereco> ListarTodos() => _context.Enderecos.ToList();
    }
}
