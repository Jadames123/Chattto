using Chattto.Model;
using Chattto.Model.ModelDto;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

namespace Chattto.ApiUserInterface
{
    [Headers("Content-Type: application/json")]
    public interface IUserApi
    {
        [Post("/dj-rest-auth/login/")]
        Task<TokenDto> PostUserLoguinAsync([Body] UserLoguinDto userloguin);

        [Get("/dialogs/")]
        Task<DialogsDto> GetUserDialogsAsync();
    }
}  