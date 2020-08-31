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
    /// Interaction logic for winCliente.xaml
    /// </summary>
    public partial class winCliente : Window
    {
        List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();

        public winCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtApellido.Text != "" && txtDni.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && txtTelefono.Text !="")
            {
                MessageBox.Show("Cliente Agregado:  ","Registro", MessageBoxButton.OK);
                agregar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...", "Error");
            }
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void agregar()
        {
            //corregir 
            this.cliente = new Cliente(Convert.ToInt16(txtDni.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text);
            this.clientes.Add(this.cliente);
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvCliente.ItemsSource = this.clientes;
        }
    }
}
