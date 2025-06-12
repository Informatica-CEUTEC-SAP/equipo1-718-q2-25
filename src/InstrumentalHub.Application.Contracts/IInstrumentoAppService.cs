using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using System;
using InstrumentalHub.Application.Contracts.Dtos;

namespace InstrumentalHub.Application.Contracts
{
    public interface IInstrumentoAppService : ICrudAppService<
        InstrumentoDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateInstrumentoRequest>
    {
    }
}