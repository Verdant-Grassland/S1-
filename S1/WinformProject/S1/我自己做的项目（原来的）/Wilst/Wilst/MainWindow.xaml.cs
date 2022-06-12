using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wilst
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int max = 100;
            Task.Run(() =>
            {
                for (int i = 0; i <= max; i++)
                {
                    col.Dispatcher.Invoke(() =>
                    {

                        col.Value = i;
                    });

                    Thread.Sleep(100);
                }
                MessageBox.Show("加载完成");

            });

        }

        private void col_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblVal.Content = e.NewValue + "%";
        }
    }
}
