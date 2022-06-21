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
using MySql.Data.MySqlClient;
using ProjetoEscola.Models;


namespace ProjetoEscola.Views
{
    /// <summary>
    /// Lógica interna para CursoFormWindow.xaml
    /// </summary>
    public partial class CursoFormWindow : Window
    {

        private Curso _curso = new Curso();
        public CursoFormWindow()
        {
            InitializeComponent();
        }


        private void btSalvarCur_Click(object sender, RoutedEventArgs e)
        {
            _curso.NomeCurso = txtNomeCurso.Text;
            _curso.CargaH = txtCargaH.Text;
 
            _curso.Descricao = txtDescricao.Text;


            

            if ((bool)rdMatutino.IsChecked)
            {
                _curso.Turno = "Matutino";
            }
            if ((bool)rdVespet.IsChecked)
            {
                _curso.Turno = "Vespertino";
            }
            if ((bool)rdNoturno.IsChecked)
            {
                _curso.Turno = "Noturno";
            }



            try
            {
                var dao = new CursoDAO();
                dao.Insert(_curso);

                MessageBox.Show("Registro de escola cadastrado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
