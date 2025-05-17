using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace InstrumentalHub.Features;

public interface ICategoriaService: IApplicationService
{
    Task<Guid> CreateAsync(string nombre);
}