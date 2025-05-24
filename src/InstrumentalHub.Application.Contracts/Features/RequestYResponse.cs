using System;

namespace InstrumentalHub.Features;

public class RequestYResponse
{
// Requests
    public record CreateInstrumentoCategoriaRequest
    {
        public string Nombre { get; set; }
    }

    public record UpdateInstrumentoCategoriaRequest
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }

// Responses
    public record InstrumentoCategoriaResponse
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }

}