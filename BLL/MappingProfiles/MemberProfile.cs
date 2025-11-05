using AutoMapper;
using BLL.DTOs.MemberDTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MappingProfiles
{
    public class MemberProfile:Profile
    {
        public MemberProfile() {

            CreateMap<Member, GetAllDTO>()
                        .ForMember(dist => dist.Gender,
                            Options => Options.MapFrom(src => src.Gender.ToString()));

            CreateMap<Member, GetDetailsDTO>()
                        .ForMember(dist => dist.Gender, Options => Options.MapFrom(src => src.Gender.ToString()))
                        .ForMember(dist => dist.Address, Options => Options.MapFrom(src => $"{src.Address.BuildingNo}-{src.Address.Street}-{src.Address.City}"))
                        .ForMember(dist => dist.DateOfBirth, Options => Options.MapFrom(src => src.DateOfBirth.ToShortDateString()));



            CreateMap<CreateDTO, Member>()
                        .ForMember(dist => dist.Gender, Options => Options.MapFrom(src => src.Gender.ToString()))
                        .ForMember(dist => dist.Address, Options => Options.MapFrom(src => $"{src.Address.BuildingNo}-{src.Address.Street}-{src.Address.City}"))
                        .ForMember(dist => dist.DateOfBirth, Options => Options.MapFrom(src => src.DateOfBirth.ToShortDateString()));

        }
    }
}
