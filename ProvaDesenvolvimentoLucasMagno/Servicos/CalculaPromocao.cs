using Dominio.Entidades;
using Dominio.Entidades.Promocoes;

namespace Servicos
{
    public static class CalculaPromocao
    {
        public static double Calcular(Produto produto)
        {
            switch (produto.Promocao)
            {
                case PromocaoEnum.PagueUmLeveDois:
                    var pagueUmLeveDois = new PagueUmLeveDois();
                    return pagueUmLeveDois.CalculaPromocao(produto);

                case PromocaoEnum.TresPorDez:
                    var tresPorDez = new TresPorDez();
                    return tresPorDez.CalculaPromocao(produto);

                default:
                    return produto.Quantidade * produto.Preco;
            }
        }
    }
}
