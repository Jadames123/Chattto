using AutoMapper;
using Chattto.Model;
using Chattto.Model.ModelDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.MapperService.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserLoguinDto, UserLoguin>().ReverseMap();

            CreateMap<TokenDto, Token>().ReverseMap();

            CreateMap<DialogsDto, Dialogs>().ReverseMap();

            CreateMap<DataDto, Data>().ReverseMap();

            CreateMap<LastMessageDto, LastMessage>().ReverseMap();
        }
    }
}
