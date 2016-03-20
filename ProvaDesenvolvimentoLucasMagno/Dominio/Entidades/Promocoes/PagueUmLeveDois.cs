using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Promocoes
{
    public class PagueUmLeveDois : PromocaoBase, ICalculaPromocao
    {

        public override string Nome
        {
            get { return "Pague 1 leve 2"; }
        }

        public double CalculaPromocao(Produto produto)
        {
            double total = 0;

            //quantidade igual a 1
            if (produto.Quantidade == 1)
                total = produto.Preco;

            //quantidade maior que 1 par
            else if (produto.Quantidade % 2 == 0)
                total += produto.Preco * produto.Quantidade / 2;

            //quantidade maior que 1 impar
            else
                total += (produto.Preco * (produto.Quantidade - 1) / 2) + produto.Preco;        

            return total;

        }
    }
}
