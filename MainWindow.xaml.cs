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

namespace VerificaGITHUB
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca b;
        public MainWindow()
        {
            InitializeComponent();
            b = new Biblioteca("Biblioteca", "indirizzo", new List<Libro>());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = new Libro(txtAutore.Text,txtTitolo.Text,txtEditore.Text,int.Parse(txtPagine.Text));
                b.AggiungiLibro(l);
                lsbBiblioteca.Items.Add(l);

            }
            catch
            {
                throw new Exception("Input errato");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int libri = b.LibriPresenti();
            txtLibriPresenti.Text = libri.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lsbBiblioteca.Items.Clear();

            lsbBiblioteca.Items.Add(b.RicercaLibro(txtCercaTitolo.Text));

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lsbBiblioteca.Items.Clear();
           List<Libro>libri= b.RicercaLibriAutore(txtCercaAutore.Text);
            foreach(Libro l in libri)
            {
                lsbBiblioteca.Items.Add(l);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Libro l = lsbBiblioteca.SelectedItem as Libro;
            
            txtReadingTime.Text= l.ReadingTime().ToString();
        }
    }
}
