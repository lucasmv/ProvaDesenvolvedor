using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }

        public Carrinho()
        {
            this.Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            if (ProdutoEstaNoCarrinho(produto))
                TrocaQuantidade(produto);
            else
                this.Produtos.Add(produto);
        }

        public void Remove(long id)
        {
            Produto produto = Produtos.FirstOrDefault(p => p.Id == id);

            Produtos.Remove(produto);
        }

        private bool ProdutoEstaNoCarrinho(Produto produto)
        {
            return Produtos.Exists(x => x.Id == produto.Id);
        }

        private void TrocaQuantidade(Produto produto)
        {
            Produto produtoCarregado = Produtos.FirstOrDefault(p => p.Id == produto.Id);

            produtoCarregado.Quantidade += produto.Quantidade;
        }

        public List<Produto> ListaProdutos()
        {
            return Produtos;
        }

        public void RemoveAll()
        {
            Produtos.Clear();
        }
    }
}
