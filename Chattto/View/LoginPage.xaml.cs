using Chattto.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Chattto
{
    public partial class LoguinPage : ContentPage
    {
        public LoguinPage()
        {
            InitializeComponent();
            BindingContext = new LoguinPageVM(Navigation);
             
        }
    }
}
