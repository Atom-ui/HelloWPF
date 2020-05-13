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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for Exceptions.xaml
    /// </summary>
    public partial class Exceptions : Window
    {
        public Exceptions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // handeld exceptions
            string str = null;
            try
            {
                str.Trim();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occured: " + ex.Message, "Exception sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            // unhandled exceptions
            str.Trim();
        }
    }
}
