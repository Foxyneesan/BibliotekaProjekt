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

namespace BibliotekaProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy WykazKsiążek.xaml
    /// </summary>
    public partial class WykazKsiążek : Page
    {
        public WykazKsiążek()
        {
            InitializeComponent();
        }
        public WykazKsiążek(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}
