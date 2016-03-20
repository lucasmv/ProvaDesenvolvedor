using Dominio.Interfaces;
using System;

namespace Dominio.Entidades.Promocoes
{
    public class TresPorDez : PromocaoBase, ICalculaPromocao
    {

        public override string Nome
        {
            get { return "3 por 10"; }
        }

        public double CalculaPromocao(Produto produto)
        {
            double total = 0;


            //quantidade multiplo de 3
            if (produto.Quantidade % 3 == 0)
                total = produto.Quantidade / 3 * 10;

            //quantidade nao multipla de 3
            else if (produto.Quantidade % 2 == 0)
                total += produto.Quantidade / 3 * 10;
            total += produto.Quantidade % 3 * produto.Preco;


            return total;
        }
    }
}
