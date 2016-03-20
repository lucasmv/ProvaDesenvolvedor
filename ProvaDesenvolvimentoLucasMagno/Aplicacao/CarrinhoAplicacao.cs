using Dominio.Entidades;
using Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class CarrinhoAplicacao
    {
        private Carrinho banco = new Carrinho();

        public void Adiciona(Produto produto)
        {
            banco.Adiciona(produto);
        }

        public void Remove(long id)
        {
            banco.Remove(id);
        }

        public List<Produto> ListaProdutos()
        {
            return banco.ListaProdutos();
        }

        public Carrinho getCarrinho()
        {
            return banco;
        }

        public double RetornaTotal()
        {
            double total = 0;

            foreach (var produto in ListaProdutos())
                total += CalculaPromocao.Calcular(produto);               

            return total;
        }

        public void ZerarCarrinho()
        {
            banco.RemoveAll();
        }
    }
}
