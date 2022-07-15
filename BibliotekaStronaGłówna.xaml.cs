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
    /// Logika interakcji dla klasy BibliotekaStronaGłówna.xaml
    /// </summary>
    public partial class BibliotekaStronaGłówna : Page
    {
        public BibliotekaStronaGłówna()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)


        {
            ListBoxItem item = (ListBoxItem)menuListBox.ItemContainerGenerator.ContainerFromIndex(menuListBox.SelectedIndex);
            string selectedType = item.Content.ToString();

            switch (selectedType)
            {
                case "Książki":
                    BibliotekaKsiążki książka = new BibliotekaKsiążki();
                    this.NavigationService.Navigate(książka);
                    break;
                case "Rezerwacje":
                    BibliotekaRezerwacje rezerwacje = new BibliotekaRezerwacje();
                    this.NavigationService.Navigate(rezerwacje);
                    break;
                case "Użytkownicy":
                    BibliotekaUżytkownicy użytkownicy = new BibliotekaUżytkownicy();
                    this.NavigationService.Navigate(użytkownicy);
                    break;
                case "Pracownicy":
                    BibliotekaPracownicy pracownicy = new BibliotekaPracownicy();
                    this.NavigationService.Navigate(pracownicy);
                    break;
                default:
                    break;
            }

        }

      

    }

}
