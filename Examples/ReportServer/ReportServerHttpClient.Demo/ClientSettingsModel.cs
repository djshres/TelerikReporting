using System.ComponentModel;

namespace ReportServerClientDemo
{
    class ClientSettingsModel : INotifyPropertyChanged
    {
        string baseAddress;
        string username;
        string password;

        public string BaseAddress
        {
            get { return this.baseAddress; }

            set
            {
                this.baseAddress = value;
                this.OnPropertyChanged("BaseAddress");
            }
        }

        public string Username
        {
            get { return this.username; }

            set
            {
                this.username = value;
                this.OnPropertyChanged("Username");
            }

        }

        public string Password
        {
            get { return this.password; }

            set
            {
                this.password = value;
                this.OnPropertyChanged("Password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (null != this.PropertyChanged )
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
