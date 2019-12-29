using HotelSuperbl.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HotelSuperbl.ViewModels
{
    public class LoginPasswordViewModel : INotifyPropertyChanged, IRequireViewIdentification
    {
        private readonly RelayCommand _loginCommand;
        private readonly RelayCommand _logoutCommand;
        private string _fullname;
        private string _position;

        public LoginPasswordViewModel()
        {
            _viewId = Guid.NewGuid();
            _loginCommand = new RelayCommand(Login, i => true);
            _logoutCommand = new RelayCommand(Logout);
        }

        public RelayCommand LoginCommand { get { return _loginCommand; } }

        public RelayCommand LogoutCommand { get { return _logoutCommand; } }

        public string Full_name
        {
            get { return _fullname; }
            set { _fullname = value; NotifyPropertyChanged("Fullname"); }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; NotifyPropertyChanged("Position"); }
        }

        private void Login(object parameter)
        {
            PasswordBox passwordBox = parameter as PasswordBox;
            string clearTextPassword = passwordBox.Password;
            try
            {
                NotifyPropertyChanged("AuthenticatedUser");
                NotifyPropertyChanged("IsAuthenticated");
                _loginCommand.RaiseCanExecuteChanged();
                _logoutCommand.RaiseCanExecuteChanged();
                //Username = string.Empty; //reset
                //passwordBox.Password = string.Empty; //reset
                //Status = string.Empty;
                _IsAuthenticated = true;
                WindowManager.CloseWindow(ViewID);

            }
            catch (UnauthorizedAccessException)
            {
                Position = "Ошибка входа! Пожалуйста, попробуйте ввести данные ещё раз!";
            }
            catch (Exception ex)
            {
                Position = string.Format("ERROR: {0}", ex.Message);
            }
        }

        private bool CanLogin(object parameter)
        {
            return !IsAuthenticated;
        }

        private bool _IsAuthenticated = false;
        public bool IsAuthenticated
        {
            get { return _IsAuthenticated; }
        }
        private Guid _viewId;
        public Guid ViewID
        {
            get { return _viewId; }
        }

        private void Logout(object parameter)
        {
            NotifyPropertyChanged("AuthenticatedUser");
            NotifyPropertyChanged("IsAuthenticated");
            _loginCommand.RaiseCanExecuteChanged();
            _logoutCommand.RaiseCanExecuteChanged();
        }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}

 