using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentalHub.Domain;
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
    public async Task<Guid> CreateAsync(string nombre)
    {   
        var categoria = new InstrumentoCategoria
        {
            Nombre = nombre
        };

        await _instrumentoCategoriaRepository.InsertAsync(categoria);
        return categoria.Id;
    }
    
    public async Task<List<InstrumentoCategoria>> GetListAsync()
    {
        return await _instrumentoCategoriaRepository.GetListAsync();
    }

    // READ (SINGLE BY ID)
    public async Task<InstrumentoCategoria> GetByIdAsync(Guid id)
    {
        return await _instrumentoCategoriaRepository.GetAsync(id);
    }

    // UPDATE
    public async Task UpdateAsync(Guid id, string nombre)
    {
        var categoria = await _instrumentoCategoriaRepository.GetAsync(id);
        categoria.Nombre = nombre;
        await _instrumentoCategoriaRepository.UpdateAsync(categoria);
    }

    // DELETE
    public async Task DeleteAsync(Guid id)
    {
        await _instrumentoCategoriaRepository.DeleteAsync(id);
    }
}