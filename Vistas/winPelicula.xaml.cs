using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for winPelicula.xaml
    /// </summary>
    public partial class winPelicula : Window
    {
        int codigo = 0;
        List<Pelicula> peliculas = new List<Pelicula>();
        Pelicula pelicula = new Pelicula();

        public winPelicula()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtClase.Text != "" && txtDuracion.Text != "" && txtGenero.Text != "" && txtTitulo.Text != "")
            {
                MessageBox.Show("Pelicula Agregada", "Registro", MessageBoxButton.OK);
                codigo++;
                agregar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...","Error");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void limpiar() {
            txtClase.Text = "";
            txtDuracion.Text = "";
            txtGenero.Text = "";
            txtTitulo.Text = "";
        }

        private void agregar()
        {
            pelicula = new Pelicula(Convert.ToString(codigo), txtTitulo.Text, txtDuracion.Text, txtGenero.Text, txtClase.Text);
            this.peliculas.Add(pelicula);
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvPeliculas.ItemsSource = this.peliculas;
        }
    }
}
