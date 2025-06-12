using System;

namespace InstrumentalHub.Application.Contracts.Dtos
{
    public class CreateUpdateInstrumentoRequest
    {
        public string Nombre { get; set; }
        public Guid CategoriaId { get; set; }
    }
}