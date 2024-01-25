using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Study
{
    public class LoginVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyChanged)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyChanged));
        }




        private LoginModel _loginModel;

        public LoginModel loginModel
        {
            get
            {
                if (_loginModel == null)
                    _loginModel = new LoginModel();
                return _loginModel;
            }
            set
            {
                _loginModel = value;
                RaisePropertyChanged(nameof(LoginModel));
            }
        }

        //也可以使用构造函数的方式，添加了一个构造函数`LoginVM()`，初始化`_LoginModel`对象
        /*
        public LoginVM()
        {
            _loginModel = new LoginModel();

        }

        */
    }
}
