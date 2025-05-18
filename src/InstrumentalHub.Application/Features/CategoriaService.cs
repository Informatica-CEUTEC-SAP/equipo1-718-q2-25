using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentalHub.Domain;
using InstrumentalHub.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace InstrumentalHub.Features;

public class CategoriaService: ApplicationService, ICategoriaService
{
    //Inyección de dependencias del repositorio
    private readonly IRepository<InstrumentoCategoria, Guid> _instrumentoCategoriaRepository;
    
    public CategoriaService(IRepository<InstrumentoCategoria, Guid> instrumentoCategoriaRepository)
    {
        _instrumentoCategoriaRepository = instrumentoCategoriaRepository;
    }
    
    //Métodos segun el contrato

    public async Task<List<InstrumentoCategoriaDto>> GetListAsync()
    {
        var instrumentoCategoria = await _instrumentoCategoriaRepository.GetListAsync();
        return ObjectMapper.Map<List<InstrumentoCategoria>, List<InstrumentoCategoriaDto>>(instrumentoCategoria);
    }

    public async Task<InstrumentoCategoriaDto> GetAsync(Guid id)
    {
        var item = await _instrumentoCategoriaRepository.GetAsync(id);
        return ObjectMapper.Map<InstrumentoCategoria, InstrumentoCategoriaDto>(item);
        
    }
    
    public async Task<InstrumentoCategoriaDto> CreateAsync(CreateUpdateInstrumentoCategoriaDto input)
    {
        var item = ObjectMapper.Map<CreateUpdateInstrumentoCategoriaDto, InstrumentoCategoria>(input);
        item = await _instrumentoCategoriaRepository.InsertAsync(item);
        return ObjectMapper.Map<InstrumentoCategoria, InstrumentoCategoriaDto>(item);
    }
    
    public async Task<InstrumentoCategoriaDto> UpdateAsync(Guid id, CreateUpdateInstrumentoCategoriaDto input)
    {
        var item = await _instrumentoCategoriaRepository.GetAsync(id);
        ObjectMapper.Map(input, item);
        item = await _instrumentoCategoriaRepository.UpdateAsync(item);
        return ObjectMapper.Map<InstrumentoCategoria, InstrumentoCategoriaDto>(item);
    }
    
    public async Task DeleteAsync(Guid id)
    {
        await _instrumentoCategoriaRepository.DeleteAsync(id);
    }
}