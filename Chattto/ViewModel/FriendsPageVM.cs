using Chattto.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Chattto.ViewModel
{
    public class FriendsPageVM : INotifyPropertyChanged
    {
        #region Variable

        #endregion

        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<UserModel> MyCollectionView { get; set; }
        #endregion

        #region Builders
        public FriendsPageVM()
        {

            //This object is only to proof

            MyCollectionView = new ObservableCollection<UserModel>
            {
                new UserModel {Name = "Arelis", State="Online"},
                new UserModel {Name = "Albaro", State = "Offline"},
                new UserModel {Name = "Patric", State = "Offline"},
                new UserModel {Name = "Merlina", State = "Online"},
                new UserModel {Name = "Arelis" , State = "Offline"},
                new UserModel {Name = "Albaro" , State = "Online"},
                new UserModel {Name = "Patric" , State = "Offline"},
                new UserModel {Name = "Merlina" , State = "Offline"},
                new UserModel {Name = "Arelis" , State = "Offline"},
                new UserModel {Name = "Albaro" , State = "Offline"},
                new UserModel {Name = "Patric" , State = "Online"},
                new UserModel {Name = "Merlina" , State = "Online"}
            };
        }
        #endregion

    }
}
