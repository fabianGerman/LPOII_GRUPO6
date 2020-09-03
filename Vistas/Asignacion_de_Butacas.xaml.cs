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
    /// Interaction logic for Asignacion_de_Butacas.xaml
    /// </summary>
    public partial class Asignacion_de_Butacas : Window
    {
        public Asignacion_de_Butacas()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.Background = Brushes.Green;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            button10.Background = Brushes.Green;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            button11.Background = Brushes.Green;
        }
    }
}
