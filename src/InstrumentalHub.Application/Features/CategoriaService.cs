using System;
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
}