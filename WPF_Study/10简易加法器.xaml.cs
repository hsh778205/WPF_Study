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
    /// _10简易加法器.xaml 的交互逻辑
    /// </summary>
    public partial class _10简易加法器 : Window
    {
        public _10简易加法器()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            int c = a + b;
            txtTotal.Text = c.ToString();
        }
    }
}
