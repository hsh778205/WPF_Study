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
    /// _11图书馆程序_一_.xaml 的交互逻辑
    /// </summary>
    public partial class _11图书馆程序_一_ : Window
    {
        public _11图书馆程序_一_()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPassword.Text;

            if (userName == "wpf" && password == "666")
            {
                //MessageBox.Show("Login");
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
                txtName.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
