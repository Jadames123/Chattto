using AutoMapper;
using Chattto.MapperService;
using Chattto.Model;
using Chattto.Refit;
using Chattto.View;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Chattto.ViewModel
{
    public class LoguinPageVM : INotifyPropertyChanged
    {
        #region Variable
        public string _txtUser, _txtPassword;
        private UserLoguin userLoguin;
        private readonly RefitConection refitConection;
        private INavigation navigation;
        #endregion 

        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        public string TxtUser
        {
            get { return _txtUser; }
            set { _txtUser = value; }
        }
        public string TxtPassword
        {
            get { return _txtPassword; }
            set { _txtPassword = value; }
        }
        #endregion

        #region Builder
        public LoguinPageVM(INavigation navigation)
        {
            this.navigation = navigation;
            refitConection = new RefitConection(MapperSetting._mapper);

        }
        #endregion

        #region Funtions
        public async void Loguin()
        {
            //To know if user is correct on page

            //await App.Current.MainPage.DisplayAlert("Login", $"Seccion started \nuser: {TxtUser} \nclave: {TxtPassword}", "ok");

            userLoguin = new UserLoguin
            {
                Username = TxtUser,
                Password = TxtPassword
            };

            if (!string.IsNullOrEmpty(TxtUser) && !string.IsNullOrEmpty(TxtPassword))
            {

                try
                {
                    var UserResponse = await refitConection.PostUserAsync(userLoguin);

                    //var DialogResponse = refitConection.GetUserDialog();

                    await navigation.PushModalAsync(new FriendsPage());

                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Wrong", ex.StackTrace, "Acept");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Warning", "Empty Fields", "Acept");
            }
        }
        #endregion

        #region Commands

        public ICommand BtnLoguin => new Command(Loguin);
        #endregion
    }
}
