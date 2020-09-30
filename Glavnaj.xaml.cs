using System;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Data_base;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Glavnaj.xaml
    /// </summary>
    public partial class Glavnaj : UserControl
    {
        Model1 db;
        public Glavnaj()
        {
            InitializeComponent();
            db = new Model1();
            db.products.Load();
            grid_glav.ItemsSource = db.products.Local.ToBindingList();
            
            db.Dispose();
            
        }


    }
}
