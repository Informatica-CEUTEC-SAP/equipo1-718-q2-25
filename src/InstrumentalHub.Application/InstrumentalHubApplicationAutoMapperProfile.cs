using AutoMapper;
//using InstrumentalHub.Application.Contracts;
using InstrumentalHub.Domain;
using InstrumentalHub.Dtos;

namespace InstrumentalHub;

public class InstrumentalHubApplicationAutoMapperProfile : Profile
{
    public InstrumentalHubApplicationAutoMapperProfile()
    {
        CreateMap<InstrumentoCategoria, InstrumentoCategoriaDto>();
        CreateMap<CreateUpdateInstrumentoCategoriaDto, InstrumentoCategoria>();
      
    }
}
