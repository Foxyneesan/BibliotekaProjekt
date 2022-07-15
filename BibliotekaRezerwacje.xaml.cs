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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BibliotekaProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy BibliotekaRezerwacje.xaml
    /// </summary>
    public partial class BibliotekaRezerwacje : Page
    {
        public BibliotekaRezerwacje()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Zobacz Wykaz Książek
            WykazRezerwacji wykazRezerwacji = new WykazRezerwacji(this.listaRezerwacji.SelectedItem);
            this.NavigationService.Navigate(wykazRezerwacji);
        }
    }
}
