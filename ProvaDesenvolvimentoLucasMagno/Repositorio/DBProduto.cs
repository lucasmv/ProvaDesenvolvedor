using Dominio.Entidades;
using Dominio.Entidades.Promocoes;
using System.Data.Entity;

namespace Repositorio
{
    public class DBProduto:DbContext
    {
        public DBProduto():base("CadastroDeProdutos")
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

    }
}
