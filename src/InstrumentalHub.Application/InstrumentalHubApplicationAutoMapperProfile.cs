using AutoMapper;
using InstrumentalHub.Domain.Models;
using InstrumentalHub.Application.Contracts.Dtos;

namespace InstrumentalHub;

public class InstrumentalHubApplicationAutoMapperProfile : Profile
{
    public InstrumentalHubApplicationAutoMapperProfile()
    {
        // Mapeos para Instrumento
        CreateMap<Instrumento, InstrumentoDto>();
        CreateMap<CreateUpdateInstrumentoDto, Instrumento>();
    }
}