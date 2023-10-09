using AutoMapper;
using Dto;
using Entity;
using projectAyallaEfratNoa.Controllers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<BusinessTbl, BusinessTblDto>();
        CreateMap<BusinessTblDto, BusinessTbl>();
    }
}