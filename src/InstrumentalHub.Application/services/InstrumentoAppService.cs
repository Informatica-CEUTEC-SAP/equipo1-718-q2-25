using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using InstrumentalHub.Domain.Models;
using InstrumentalHub.Application.Contracts.Dtos;
using System;

namespace InstrumentalHub.Application.Contracts
{
    public class InstrumentoAppService : 
        CrudAppService<
            Instrumento,                   // La entidad principal
            InstrumentoDto,                // El DTO para exponer datos
            Guid,                          // Tipo de la llave primaria
            PagedAndSortedResultRequestDto,// Filtro de paginación y ordenamiento
            CreateUpdateInstrumentoRequest     // DTO para crear/actualizar
        >, 
        IInstrumentoAppService            // Implementa tu interfaz
    {
        public InstrumentoAppService(IRepository<Instrumento, Guid> repository)
            : base(repository)
        {
        }
        
    }
}