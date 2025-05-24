using System;

namespace InstrumentalHub.Application.Contracts.Dtos
{
    public class InstrumentoDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Guid CategoriaId { get; set; }
        
    }
}