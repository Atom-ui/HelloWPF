﻿using System;
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
    /// Interaction logic for DataGridColumns.xaml
    /// </summary>
    public partial class DataGridColumns : Window
    {
        public DataGridColumns()
        {
            InitializeComponent();
            InitializeComponent();
            List<Gebruiker> users = new List<Gebruiker>
            {
                new Gebruiker(1, "jksfds", DateTime.Now),
                new Gebruiker(2, "lqmlsm", DateTime.Today)
            };
            DgUsers.ItemsSource = users;
        }
    }
}
