using System;
using System.Collections.Generic;
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
    /// _16图书馆程序_三_Model和ViewModel的创建和配置.xaml 的交互逻辑
    /// </summary>
    public partial class _16图书馆程序_三_Model和ViewModel的创建和配置 : Window
    {
        LoginVM loginVM;
        public _16图书馆程序_三_Model和ViewModel的创建和配置()
        {
            InitializeComponent();
            loginVM = new LoginVM();
            this.DataContext = loginVM;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (loginVM.loginModel.UserName == "wpf" && loginVM.loginModel.Password == "777")
            {
                //MessageBox.Show("Login");
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
                loginVM.loginModel.UserName = "";
                loginVM.loginModel.Password = "";
                loginVM.loginModel = loginVM.loginModel;
            }
        }
    }
}

