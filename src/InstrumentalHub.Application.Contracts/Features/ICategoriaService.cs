using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using InstrumentalHub.Application.Contracts;
using InstrumentalHub.Domain;
using Volo.Abp.Application.Services;

namespace InstrumentalHub.Features;

public interface ICategoriaService: IApplicationService
{
     Task<Guid> CreateAsync(string nombre);
     Task<List<InstrumentoCategoria>> GetListAsync();
     Task<InstrumentoCategoria> GetByIdAsync(Guid id);
     Task UpdateAsync(Guid id, string nombre);
     Task DeleteAsync(Guid id);
     

}