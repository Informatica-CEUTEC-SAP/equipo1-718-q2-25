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

    public async Task<List<RequestYResponse.InstrumentoCategoriaResponse>> GetListAsync()
    {
        var categorias = await _instrumentoCategoriaRepository.GetListAsync();
        return ObjectMapper.Map<List<InstrumentoCategoria>, List<RequestYResponse.InstrumentoCategoriaResponse>>(categorias);
    }

    public async Task<RequestYResponse.InstrumentoCategoriaResponse> GetAsync(Guid id)
    {
        var categoria = await _instrumentoCategoriaRepository.GetAsync(id);
        return ObjectMapper.Map<InstrumentoCategoria, RequestYResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task<RequestYResponse.InstrumentoCategoriaResponse> CreateAsync(RequestYResponse.CreateInstrumentoCategoriaRequest request)
    {
        var categoria = new InstrumentoCategoria
        {
            Nombre = request.Nombre
        };

        categoria = await _instrumentoCategoriaRepository.InsertAsync(categoria);
        return ObjectMapper.Map<InstrumentoCategoria, RequestYResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task<RequestYResponse.InstrumentoCategoriaResponse> UpdateAsync(RequestYResponse.UpdateInstrumentoCategoriaRequest request)
    {
        var categoria = await _instrumentoCategoriaRepository.GetAsync(request.Id);
        categoria.Nombre = request.Nombre;

        await _instrumentoCategoriaRepository.UpdateAsync(categoria);
        return ObjectMapper.Map<InstrumentoCategoria, RequestYResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _instrumentoCategoriaRepository.DeleteAsync(id);
    }
}
    