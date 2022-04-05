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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = passBoxSenha.Password.ToString();

            if (usuario == "Fernando" && senha == "123")
            {
                MessageBox.Show("Usuário autênticado com sucesso");
                selecao principal = new selecao();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_1(sender, e);
            }
        }
    }
}
