using System;
using Volo.Abp.Domain.Entities;

namespace InstrumentalHub.Domain
{
    public class InstrumentoCategoria : BasicAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
    }
}
