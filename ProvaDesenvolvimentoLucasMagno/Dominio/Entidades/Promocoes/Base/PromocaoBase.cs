using System;

namespace Dominio.Entidades.Promocoes
{
    public abstract class PromocaoBase
    {
        public int Id { get; set; }
        public abstract string Nome { get; }
    }
}
