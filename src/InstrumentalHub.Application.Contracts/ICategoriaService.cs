using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using InstrumentalHub.Application.Contracts;
//using InstrumentalHub.Domain;
    

  
using InstrumentalHub.Dtos;
using InstrumentalHub.Dtos.Requests;
using Volo.Abp.Application.Services;


namespace InstrumentalHub.Features;

public interface ICategoriaService : IApplicationService
{
    Task<List<CategoriaResponse.InstrumentoCategoriaResponse>> GetListAsync();
    Task<CategoriaResponse.InstrumentoCategoriaResponse> GetAsync(Guid id);
    Task<CategoriaResponse.InstrumentoCategoriaResponse> CreateAsync(CategoriaRequest.CreateInstrumentoCategoriaRequest request);
    Task<CategoriaResponse.InstrumentoCategoriaResponse> UpdateAsync(CategoriaRequest.UpdateInstrumentoCategoriaRequest request);
    Task DeleteAsync(Guid id);





}