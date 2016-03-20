using Aplicacao;
using Dominio.Entidades;
using Dominio.Entidades.Promocoes;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var appProduto = new ProdutoAplicacao();
            var appCarrinho = new CarrinhoAplicacao();

            var p = new Produto
            {
                Nome = "Caneta",
                Preco = 4,
                Promocao = PromocaoEnum.PagueUmLeveDois
            };

            var p2 = new Produto
            {
                Nome = "HD",
                Preco = 5,
                Promocao = PromocaoEnum.TresPorDez
            };

            var p3 = new Produto
            {
                Nome = "Chocolate",
                Preco = 3,
                Promocao = PromocaoEnum.SemPromocao
            };

            var p4 = new Produto
            {
                Nome = "Fone de Ouvido",
                Preco = 15,
                Promocao = PromocaoEnum.PagueUmLeveDois
            };

            appProduto.Salvar(p);
            appProduto.Salvar(p2);
            appProduto.Salvar(p3);
            appProduto.Salvar(p4);

            var listaProdutos = appProduto.Listar();

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine("Codigo {0} - {1} - {2}", produto.Id, produto.Nome, produto.Promocao);
            }

            //var p = appProduto.RetornaPorId(9);
            //p.Quantidade = 3;

            //var p2 = appProduto.RetornaPorId(11);
            //p2.Quantidade = 5;

            //var p3 = appProduto.RetornaPorId(10);
            //p3.Quantidade = 6;

            //var p4 = appProduto.RetornaPorId(9);
            //p4.Quantidade = 5;

            //appCarrinho.Adiciona(p);
            //appCarrinho.Adiciona(p2);
            //appCarrinho.Adiciona(p3);
            //appCarrinho.Adiciona(p4);

            //var listaProdutos = appCarrinho.ListaProdutos();

            //foreach (var produto in listaProdutos)
            //{
            //    Console.WriteLine("Codigo {0} - {1} - {2} - {3}", produto.Id, produto.Nome, produto.Promocao, produto.Quantidade);
            //}

            //Console.ReadKey();

            //double total = 0;
            //int quantidade = 5;
            //double preco = 4;

            //int teste = quantidade % 3;
            //int teste2 = quantidade / 3;

            //if (quantidade % 3 == 0)
            //{
            //    total += quantidade / 3 * 10;
            //}
            //else
            //{
            //    total += quantidade / 3 * 10;
            //    total += quantidade % 3 * preco;
            //}

            //Console.WriteLine(total);
            //Console.ReadKey();
        }
    }
}
