using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Study
{
    /// <summary>
    /// _14图书馆程序_二_绑定.xaml 的交互逻辑
    /// </summary>
    public partial class _14图书馆程序_二_绑定 : Window, INotifyPropertyChanged
    {
        public _14图书馆程序_二_绑定()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyChanged)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyChanged));
        }

        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                RaisePropertyChanged("UserName");
            }
        }


        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                RaisePropertyChanged("Password");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (UserName == "wpf" && Password == "666")
            {
                //MessageBox.Show("Login");
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
                UserName = "";
                Password = "";
            }
        }
    }
}
