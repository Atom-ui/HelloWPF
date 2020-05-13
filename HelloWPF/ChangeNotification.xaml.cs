using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for ChangeNotification.xaml
    /// </summary>
    public partial class ChangeNotification : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public ChangeNotification()
        {
            InitializeComponent();
            users.Add(new User("Kwak"));
            users.Add(new User("svfdoimfjdmq"));
            LbUsers.ItemsSource = users;
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User("new user"));
        }

        private void BtnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (LbUsers.SelectedItem != null)
                (LbUsers.SelectedItem as User).Name = "Random Name";
        }

        private void BtnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (LbUsers.SelectedItem != null)
                users.Remove(LbUsers.SelectedItem as User);
        }
    }

    internal class User : INotifyPropertyChanged
    {
        public User(string name)
        {
            Name = name;
        }
        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (this._name != value)
                {
                    this._name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        private void NotifyPropertyChanged(string v)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
