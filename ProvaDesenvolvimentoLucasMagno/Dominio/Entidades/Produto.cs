using Dominio.Entidades.Promocoes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Preco { get; set; }
        public PromocaoEnum Promocao { get; set; }

        [NotMapped]
        public virtual int Quantidade { get; set; }
    }
}
