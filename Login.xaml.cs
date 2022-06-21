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
using ProjetoEscola.Views;

namespace ProjetoEscola
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = new CursoFormWindow();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var form = new EscolaFormWindow();
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var form = new CursoListWindow();
            form.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var form = new EscolaListWindow();
            form.Show();
        }
    }
}
