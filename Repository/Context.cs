using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias{ get; set; }
        //Ñão é necessário inserir DbSet<Endereco>. É gerado dentro do banco pois Usuarios tem relacionamento
        public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

    }
}
