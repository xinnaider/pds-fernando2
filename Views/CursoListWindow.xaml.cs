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
using ProjetoEscola.Models;

namespace ProjetoEscola.Views
{
    /// <summary>
    /// Lógica interna para CursoListWindow.xaml
    /// </summary>
    public partial class CursoListWindow : Window
    {
        public CursoListWindow()
        {
            InitializeComponent();
            Loaded += CursoListWindow_Loaded;
        }

        private void CursoListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var dao = new CursoDAO();
                List<Curso> listaCursos = dao.List();

                dataGridCurso.ItemsSource = listaCursos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Atualizar_Click(object sender, RoutedEventArgs e)
        {
            var cursoSelecionada = dataGridCurso.SelectedItem as Curso;
            var resultado = MessageBox.Show($"Deseja realmente atualizar os dados de curso '{cursoSelecionada.NomeCurso}' ?", "Confirmação de alteração",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            var form = new CursoFormWindow(cursoSelecionada);
            form.ShowDialog();

            CarregarListagem();
        }

        private void Button_Remover_Click(object sender, RoutedEventArgs e)
        {
            var cursoSelecionada = dataGridCurso.SelectedItem as Curso;

            var resultado = MessageBox.Show($"Deseja realmente remover o curso '{cursoSelecionada.NomeCurso}' ?", "Confirmação de Exclusão",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (resultado == MessageBoxResult.Yes)
                {

                    var dao = new CursoDAO();
                    dao.Delete(cursoSelecionada);

                    MessageBox.Show("Registro removido com sucesso!");
                    CarregarListagem();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CarregarListagem()
        {
            try
            {
                var dao = new CursoDAO();
                List<Curso> listaCurso = dao.List();

                dataGridCurso.ItemsSource = listaCurso;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
