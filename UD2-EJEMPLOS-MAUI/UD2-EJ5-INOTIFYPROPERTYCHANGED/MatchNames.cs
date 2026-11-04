using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UD2_EJ5_INOTIFYPROPERTYCHANGED
{
    internal class MatchNames : INotifyPropertyChanged
    {
        //PROPIEDADES

        private String? _name;

        public String? Name
        {
            get { return _name; }

            set
            {
                _name = value;
                NotifyPropertyChanged("FullName");
            }
        }

        private String? _lastname;

        public String? LastName
        {
            get { return _lastname; }

            set
            {
                _lastname = value;
                NotifyPropertyChanged("FullName");
            }

        }

        private String? _fullname;

        public String? FullName
        {
            get 
            {
                _fullname = Name + " " + LastName;
                return _fullname;
            }

            set { }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
