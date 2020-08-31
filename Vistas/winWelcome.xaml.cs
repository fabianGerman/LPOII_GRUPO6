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
    /// Lógica de interacción para winWelcome.xaml
    /// </summary>
    public partial class winWelcome : Window
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        public winWelcome()
        {
            InitializeComponent();
        }
         
        /*EVENTOS PRINCIPALES*/
        private void btnIngreso_Click(object sender, RoutedEventArgs e)
        {
            winMain oWinMain = new winMain();
            CargarLista();
            if (controlarIngreso(txtUsuario.Text, txtContra.Text) == true)
            {
                MessageBox.Show("Debe completar los campos");
                limpiar();
            }
            else
            {
                if (validarUsuario(txtUsuario.Text, txtContra.Text) == null)
                {
                    MessageBox.Show("Usuario no Registrado");
                    limpiar();
                }
                else
                {
                    
                    oWinMain.UsuarioLogeado = validarUsuario(txtUsuario.Text, txtContra.Text);
                    MessageBox.Show("Bienvenido");
                    oWinMain.Show();
                    limpiar();
                }
            }
               
        }

        /*FUNCIONES INTERNAS*/
        private void CargarLista()
        {
            Usuario usuario1 = new Usuario(1, "admin", "123", "asdfg", "administrador");
            Usuario usuario2 = new Usuario(2, "vend", "1234", "asdfg", "vendedor");
            this.listaUsuarios.Add(usuario1);
            this.listaUsuarios.Add(usuario2);
        }

        private Usuario validarUsuario(String us, string pass)
        {
            return listaUsuarios.Find(x => x.Usu_NombreUsuario.Equals(us) || x.Usu_Password.Equals(pass)); //controlar si esta bien
        }

        private Boolean controlarIngreso(string us, string pass)
        {
            return us.Equals("") || pass.Equals("");
        }

        private void limpiar()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }
    }
}
