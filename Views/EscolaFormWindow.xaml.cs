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
using MySql.Data.MySqlClient;
using ProjetoEscola.Models;

namespace ProjetoEscola.Views
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        private Escola _escola = new Escola();

        public EscolaFormWindow()
        {
            InitializeComponent();
        }

        public EscolaFormWindow(Escola escolaSelecionada)
        {
            InitializeComponent();
            Loaded += EscolaFormWindow_Loaded;
            _escola = escolaSelecionada;
        }

        private void EscolaFormWindow_Loaded(object sender, RoutedEventArgs e)
        {

            txtNomeFantasia.Text = _escola.NomeFantasia;
            txtRazaoSocial.Text = _escola.RazaoSocial;
            txtCNPJ.Text = _escola.Cnpj;
            txtInscEstudal.Text = _escola.InscEstadual;
            dtCriacao.SelectedDate = _escola.DataCriacao;
            txtResponsavel.Text = _escola.Responsavel;
            txtResponsavelTelefone.Text = _escola.ResponsavelTelefone;
            txtEmail.Text = _escola.Email;
            txtTelefone.Text = _escola.Telefone;
            txtRua.Text = _escola.Rua;
            txtNumero.Text = _escola.Numero;
            txtBairro.Text = _escola.Bairro;
            txtComplemento.Text = _escola.Complemento;
            txtCidade.Text = _escola.Cidade;
            txtEstado.Text = _escola.Estado;

            if (_escola.Tipo == "Pública")
            {
                rdTipoPublica.IsChecked = true;
            }
            else
            {
                rdTipoPrivada.IsChecked = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _escola.NomeFantasia = txtNomeFantasia.Text;
            _escola.RazaoSocial = txtRazaoSocial.Text;
            _escola.Cnpj = txtCNPJ.Text;
            _escola.InscEstadual = txtInscEstudal.Text;
            _escola.DataCriacao = dtCriacao.SelectedDate;
            _escola.Responsavel = txtResponsavel.Text;
            _escola.ResponsavelTelefone = txtResponsavelTelefone.Text;
            _escola.Email = txtEmail.Text;
            _escola.Telefone = txtTelefone.Text;
            _escola.Rua = txtRua.Text;
            _escola.Numero = txtNumero.Text;
            _escola.Bairro = txtBairro.Text;
            _escola.Complemento = txtComplemento.Text;
            _escola.Cidade = txtCidade.Text;
            _escola.Estado = txtEstado.Text;
            _escola.Tipo = "Pública";

            if ((bool)rdTipoPrivada.IsChecked)
                _escola.Tipo = "Privada";


            try
            {
                var dao = new EscolaDAO();

                if (_escola.Id > 0)
                {
                    dao.Update(_escola);
                    MessageBox.Show("Registro de escola Atualizado com sucesso.");
                }
                else
                {
                    dao.Insert(_escola);
                    MessageBox.Show("Registro de escola cadastrado com sucesso.");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

            

        }
    }
}
