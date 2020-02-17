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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsACaso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] arr = new string[5];
        int c = 0;


        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            arr[c] = txtN.Text;
            c++;
            txtN.Clear();
            txtN.Focus();
            btnIn.IsEnabled = true;
            if (c >= 5)
            {
                btnIn.IsEnabled = false;
            }
        }

        private void btnSt_Click(object sender, RoutedEventArgs e)
        {
            for (c = 0;c < arr.Length; c++)
            {

            }
        }
    }
}
