using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using InstrumentalHub.Application.Contracts;
using InstrumentalHub.Domain;
using InstrumentalHub.Dtos;
using Volo.Abp.Application.Services;


namespace InstrumentalHub.Features;

public interface ICategoriaService: IApplicationService
{
     Task<List<InstrumentoCategoriaDto>> GetListAsync();
     Task<InstrumentoCategoriaDto> GetAsync(Guid id);
     Task<InstrumentoCategoriaDto> CreateAsync(CreateUpdateInstrumentoCategoriaDto input);
     Task<InstrumentoCategoriaDto> UpdateAsync(Guid id, CreateUpdateInstrumentoCategoriaDto input);
    Task DeleteAsync(Guid id);
     

}