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
        public winWelcome()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, RoutedEventArgs e)
        {
            
            Usuario usuario1 = new Usuario("admin", "123");
            Usuario usuario2 = new Usuario("vendedor", "123");

            if (txtUsuario.Text == usuario1.Usu_NombreUsuario && txtContra.Text == usuario1.Usu_Contra)
            {
                MessageBox.Show("Bienvenido, "+ txtUsuario.Text);
                winMain oWinMain = new winMain();
                oWinMain.Show();
            }
            else
            {
                if (txtUsuario.Text == usuario2.Usu_NombreUsuario && txtContra.Text == usuario2.Usu_Contra)
                {
                    MessageBox.Show("Bienvenido, " + txtUsuario.Text);
                    winMain oWinMain = new winMain();
                    oWinMain.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
                
        }
    }
}
