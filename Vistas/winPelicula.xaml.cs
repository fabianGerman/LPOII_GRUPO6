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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for winPelicula.xaml
    /// </summary>
    public partial class winPelicula : Window
    {
        public winPelicula()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtClase.Text != "" && txtDuracion.Text != "" && txtGenero.Text != "" && txtTitulo.Text != "")
            {
                MessageBox.Show("Pelicula Agregada:  " + "Titulo :" + txtTitulo.Text + ", Genero: " + txtGenero.Text + ", Clase: " + txtClase.Text);
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...");
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
    }
}
