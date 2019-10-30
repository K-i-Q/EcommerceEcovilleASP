using Domain;
using Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceEcovilleASP.DAL
{
    public class ProdutoDAO : IRepository<Produto>
    {

        //readonly para ser usado apenas no construtor e na declaração
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }
        

        public void EditarProduto(Produto p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
        public void RemoverProduto(Produto p)
        {
            _context.Produtos.Remove(p);
            _context.SaveChanges();
        }

        public bool ExisteProduto(string nome) => _context.Produtos.FirstOrDefault(x => x.Nome.Equals(nome)) != null;

        
        //init
        public bool Cadastrar(Produto objeto)
        {
            if (objeto != null)
            {
                _context.Produtos.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Produto> ListarTodos() => _context.Produtos.ToList();

        public Produto BuscarPorId(long? id) => _context.Produtos.Find(id);
    }
}