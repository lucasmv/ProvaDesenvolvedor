using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Promocoes
{
    public enum PromocaoEnum
    {
         [Display(Name = "Sem Promoção")]
        SemPromocao,

         [Display(Name = "Pague 1 leve 2")]
        PagueUmLeveDois,

         [Display(Name = "3 por 10")]
        TresPorDez
    }
}
