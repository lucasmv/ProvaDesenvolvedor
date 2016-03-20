using Dominio.Entidades;
using Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao
{
    public class ProdutoAplicacao
    {
        public DBProduto Banco { get; set; }

        public ProdutoAplicacao()
        {
            Banco = new DBProduto();
        }

        public void Salvar(Produto produto)
        {
            Banco.Produtos.Add(produto);
            Banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return Banco.Produtos.ToList();
        }

        public void Alterar(Produto produto)
        {
            Produto produtoSalvar = Banco.Produtos.Where(x => x.Id == produto.Id).First();
            produtoSalvar.Nome = produto.Nome;
            produtoSalvar.Preco = produto.Preco;
            produtoSalvar.Promocao = produto.Promocao;
            Banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Produto produtoExcluir = Banco.Produtos.First(x => x.Id == id);
            Banco.Set<Produto>().Remove(produtoExcluir);
            Banco.SaveChanges();
        }

        public Produto RetornaPorId(int id)
        {
            var produtoTemp = Banco.Produtos.First(x => x.Id == id);

            var produto = new Produto
            {
                Id = produtoTemp.Id,
                Nome = produtoTemp.Nome,
                Preco = produtoTemp.Preco,
                Promocao = produtoTemp.Promocao
            };

            return produto;
        }

    }
}
