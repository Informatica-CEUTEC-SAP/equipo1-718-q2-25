using System;

namespace InstrumentalHub.Dtos;

public record CategoriaResponse()
{
    public record InstrumentoCategoriaResponse
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }


}