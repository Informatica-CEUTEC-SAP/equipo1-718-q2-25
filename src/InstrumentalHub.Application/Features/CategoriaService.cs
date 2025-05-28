using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentalHub.Domain;
using InstrumentalHub.Dtos;
using InstrumentalHub.Dtos.Requests;
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

    public async Task<List<CategoriaResponse.InstrumentoCategoriaResponse>> GetListAsync()
    {
        var categorias = await _instrumentoCategoriaRepository.GetListAsync();
        return ObjectMapper.Map<List<InstrumentoCategoria>, List<CategoriaResponse.InstrumentoCategoriaResponse>>(categorias);
    }

    public async Task<CategoriaResponse.InstrumentoCategoriaResponse> GetAsync(Guid categoriaGuid)
    {
        var categoria = await _instrumentoCategoriaRepository.GetAsync(categoriaGuid);
        return ObjectMapper.Map<InstrumentoCategoria, CategoriaResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task<CategoriaResponse.InstrumentoCategoriaResponse> CreateAsync(CategoriaRequest.CreateInstrumentoCategoriaRequest request)
    {
        var categoria = new InstrumentoCategoria
        {
            Nombre = request.Nombre
        };

        categoria = await _instrumentoCategoriaRepository.InsertAsync(categoria);
        return ObjectMapper.Map<InstrumentoCategoria, CategoriaResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task<CategoriaResponse.InstrumentoCategoriaResponse> UpdateAsync(CategoriaRequest.UpdateInstrumentoCategoriaRequest request)
    {
        var categoria = await _instrumentoCategoriaRepository.GetAsync(request.Id);
        categoria.Nombre = request.Nombre;

        await _instrumentoCategoriaRepository.UpdateAsync(categoria);
        return ObjectMapper.Map<InstrumentoCategoria, CategoriaResponse.InstrumentoCategoriaResponse>(categoria);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _instrumentoCategoriaRepository.DeleteAsync(id);
    }
}
    