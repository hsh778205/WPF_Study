using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Study_LIBRARY;

namespace WPF_Study
{
    public class LoginVM : INotifyPropertyChanged
    {
        private MainWindow _main;
        public LoginVM(MainWindow main)
        {
            _main = main;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyChanged)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyChanged));
        }

        private LoginModel _loginModel = new LoginModel();

        public string UserName
        {
            get { return _loginModel.UserName; }
            set
            {
                _loginModel.UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return _loginModel.Password; }
            set
            {
                _loginModel.Password = value;
                RaisePropertyChanged("Password");
            }
        }

        void LoginFunc()
        {
            if (UserName == "wpf" && Password == "777")
            {
                //MessageBox.Show("Login");
                Index index = new Index();
                index.Show();
                _main.Hide();
            }
            else
            {
                MessageBox.Show("Error");
                UserName = "";
                Password = "";
            }
        }
        bool CanLoginExecute()
        {
            return true;
        }
        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFunc, CanLoginExecute);
            }
        }




    }
}
