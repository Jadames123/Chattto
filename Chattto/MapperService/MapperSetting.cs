using AutoMapper;
using Chattto.MapperService.MapperProfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.MapperService
{
    public class MapperSetting
    { 
        private static MapperConfiguration _configuration;

        public static void Initialization()
        {
            if(_configuration == null) 
            { 
               _configuration = new MapperConfiguration(cfg =>
               {
                   cfg.AddProfile(new UserProfile());
               });
            }
#if DEBUG
            _configuration.AssertConfigurationIsValid();

            _mapper = _configuration.CreateMapper();
#endif

        }
        public static IMapper _mapper { get; private set; }
    }
}
