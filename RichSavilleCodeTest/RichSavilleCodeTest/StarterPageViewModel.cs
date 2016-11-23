using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RichSavilleCodeTest
{
    class StarterPageViewModel : INotifyPropertyChanged
    {
        RootObject movielist;
        public RootObject Movielist
        {
            get { return movielist; }
            set
            {
                if (movielist != value)
                {
                    movielist = value;
                    OnPropertyChanged("Movielist");
                }
            }
        }

        public StarterPageViewModel()
        {
            movielist = new RootObject();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
