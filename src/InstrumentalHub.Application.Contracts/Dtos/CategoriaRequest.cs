using System;

namespace InstrumentalHub.Dtos.Requests;

public record CategoriaRequest()
{
    
// Requests
        public record CreateInstrumentoCategoriaRequest
        {
            public string Nombre { get; init; } = String.Empty;
        }

        public record UpdateInstrumentoCategoriaRequest
        {
            public Guid Id { get; set; }
            public string Nombre { get; init; } = String.Empty;
        }
    }


    
