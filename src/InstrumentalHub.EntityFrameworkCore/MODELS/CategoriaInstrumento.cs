using System;
using Volo.Abp.Domain.Entities;

namespace InstrumentalHub.Domain
{
    public class InstrumentoCategoria : Entity<Guid>
    {
        public string Nombre { get; set; }

        public InstrumentoCategoria() {}

        public InstrumentoCategoria(Guid id, string nombre) : base(id)
        {
            Nombre = nombre;
        }
    }
}
