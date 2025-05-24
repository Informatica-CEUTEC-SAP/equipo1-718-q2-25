using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using InstrumentalHub.Application.Contracts;
using InstrumentalHub.Domain;
    

  
using InstrumentalHub.Dtos;
using Volo.Abp.Application.Services;


namespace InstrumentalHub.Features;

public interface ICategoriaService : IApplicationService
{
    Task<List<RequestYResponse.InstrumentoCategoriaResponse>> GetListAsync();
    Task<RequestYResponse.InstrumentoCategoriaResponse> GetAsync(Guid id);
    Task<RequestYResponse.InstrumentoCategoriaResponse> CreateAsync(RequestYResponse.CreateInstrumentoCategoriaRequest request);
    Task<RequestYResponse.InstrumentoCategoriaResponse> UpdateAsync(RequestYResponse.UpdateInstrumentoCategoriaRequest request);
    Task DeleteAsync(Guid id);





}