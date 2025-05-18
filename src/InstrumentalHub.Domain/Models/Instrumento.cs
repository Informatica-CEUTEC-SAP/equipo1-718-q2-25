using System;
using Volo.Abp.Domain.Entities;

namespace InstrumentalHub.Domain.Models
{
    public class Instrumento : BasicAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public Guid CategoriaId { get; set; }
        public InstrumentoCategoria? Categoria { get; set; }

        public Instrumento()
        {
            Nombre = string.Empty;
        }

        public Instrumento(Guid id, string nombre, Guid categoriaId) : base(id)
        {
            Nombre = nombre;
            CategoriaId = categoriaId;
        }
    }
}