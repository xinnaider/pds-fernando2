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
    /// Lógica interna para selecao.xaml
    /// </summary>
    public partial class selecao : Window
    {
        public selecao()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btCalculadora_Click(object sender, RoutedEventArgs e)
        {
            janela1 principal = new janela1();
            principal.ShowDialog();
        }

        private void btPessoa_Click(object sender, RoutedEventArgs e)
        {
            janela2 principal2 = new janela2();
            principal2.ShowDialog();
        }
    }
}
