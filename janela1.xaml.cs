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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para janela1.xaml
    /// </summary>
    public partial class janela1 : Window
    {
        public janela1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(txtCalculo1.Text);
            int numero2 = int.Parse(txtCalculo2.Text);
            int resultado;

            txtCalculo1.Clear();
            txtCalculo2.Clear();

            resultado = numero1 * numero2;

            MessageBox.Show("O resultado da multiplicação é: " + resultado);
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btCalcular2_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(txtCalculo12.Text);
            int numero2 = int.Parse(txtCalculo22.Text);
            int resultado;

            txtCalculo12.Clear();
            txtCalculo22.Clear();

            resultado = numero1 - numero2;

            MessageBox.Show("O resultado da subtração é: " + resultado);
        }

        private void btCalcular3_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(txtCalculo13.Text);
            int numero2 = int.Parse(txtCalculo23.Text);
            int resultado;

            resultado = numero1 + numero2;

            txtCalculo13.Clear();
            txtCalculo23.Clear();

            MessageBox.Show("O resultado da soma é: " + resultado);
        }

        private void btCalcular4_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(txtCalculo43.Text);
            int numero2 = int.Parse(txtCalculo44.Text);
            int resultado;

            resultado = numero1 / numero2;

            txtCalculo43.Clear();
            txtCalculo44.Clear();

            MessageBox.Show("O resultado da divisão é: " + resultado);
        }
    }
}
