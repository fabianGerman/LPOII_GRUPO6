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
    /// Lógica de interacción para winMain.xaml
    /// </summary>
    public partial class winMain : Window
    {
        private Usuario usuarioLogeado;

        public winMain()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            abmUsuario.Visibility = System.Windows.Visibility.Hidden;
            abmCliente.Visibility = System.Windows.Visibility.Hidden;
            abmPeliculas.Visibility = System.Windows.Visibility.Hidden;
            abmProyeccion.Visibility = System.Windows.Visibility.Hidden;
            abmTicket.Visibility = System.Windows.Visibility.Hidden;
            abmButacas.Visibility = System.Windows.Visibility.Hidden;
            controlarRol();
        }

        /*EVENTOS PRINCIPALES*/
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Asignacion_de_Butacas ventana = new Asignacion_de_Butacas();
            ventana.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {

        }

        /*fUNCIONES iNTERNAS*/
        private void controlarRol()
        {
            if(this.usuarioLogeado.Rol_Codigo.Equals("administrador"))
            {
                abmUsuario.Visibility = System.Windows.Visibility.Visible;
                abmPeliculas.Visibility = System.Windows.Visibility.Visible;
                abmProyeccion.Visibility = System.Windows.Visibility.Visible;
                abmButacas.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                if(this.usuarioLogeado.Rol_Codigo.Equals("vendedor"))
                {
                    abmCliente.Visibility = System.Windows.Visibility.Visible;
                    abmTicket.Visibility = System.Windows.Visibility.Visible;
                }
                
            }
        }

        public Usuario UsuarioLogeado
        {
            get { return usuarioLogeado; }
            set { usuarioLogeado = value; }
        }

    }
}
