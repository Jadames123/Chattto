using AutoMapper;
using Chattto.ApiUserInterface;
using Chattto.Model;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chattto.Refit
{
    public class RefitConection
    {
        private readonly IUserApi _UserApi;
        private readonly IMapper _mapServices;

        public RefitConection(IMapper _mapServices)
        {
            this._mapServices = _mapServices;

            var settings = new RefitSettings()
            {
                Buffered = true,
                ContentSerializer = new SystemTextJsonContentSerializer(),
                ExceptionFactory = HttpResponseHandlerAsync
            };

            _UserApi = RestService.For<IUserApi>("http://10.0.2.2:8000", settings);

        }
        //This method send the userName & password
        public async Task<Token> PostUserAsync(UserLoguin userLoguin)
        {
            var UserResponse = _mapServices.Map<UserLoguinDto>(userLoguin);

            var Response = await _UserApi.PostUserLoguinAsync(UserResponse);

            return _mapServices.Map<Token>(Response);
        }

        public async Task<Dialogs> GetUserDialog()

        {
            var DialogResponse = await _UserApi.GetUserDialogsAsync();

            return _mapServices.Map<Dialogs>(DialogResponse);
        }

        // To handle the exceptions released
        public static Task<Exception> HttpResponseHandlerAsync(HttpResponseMessage arg)
        {
            var httpContentString = arg.Content.ReadAsStringAsync().Result;

            if (arg.IsSuccessStatusCode)

                return Task.FromResult<Exception>(null);
            else
                return Task.FromResult<Exception>(new Exception(arg.ReasonPhrase));

        }

    }
}
