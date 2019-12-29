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
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Linq;



namespace kuryeGozlemTakip
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


        private void Listele_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Kaydet_Click(object sender, RoutedEventArgs e)
        {
        }

        private void IslemKodu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void KuryeKodu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void KartTuru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SubeKodu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Sozlesmey_n_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
//ilk database path i : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kurt\Documents\DESKTOP-C0TU4TD.mdf;Integrated Security=True;Connect Timeout=30


// metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;
//provider connection string="data source=DESKTOP-C0TU4TD\SQLEXPRESS;initial catalog=kuryeGozlemDB;integrated security=True;
//MultipleActiveResultSets=True;App=EntityFramework"