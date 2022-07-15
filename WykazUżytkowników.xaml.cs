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
    /// Logika interakcji dla klasy WykazUżytkowników.xaml
    /// </summary>
    public partial class WykazUżytkowników : Page
    {
        public WykazUżytkowników()
        {
            InitializeComponent();
        }

        public WykazUżytkowników(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;

        }
    }
}
