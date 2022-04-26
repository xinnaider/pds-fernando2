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


namespace Escola_pg.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindow.xaml
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        public EscolaFormWindow()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            //informações
            string nome = txtNome.Text;
            string razao = txtRazao.Text;
            string cnpj = txtCNPJ.Text;
            string insc = txtEstadual.Text;
            //informações complementares
            string rdfator;
            string datacriacao = dtCriacao.SelectedDate?.ToString("yyyy-MM-dd");
            //responsavel
            string nome2 = txtNome2.Text;
            string telefone2 = txtTelefone2.Text;
            //endereco e contato
            string telefone3 = txtTelefone3.Text;
            string email = txtEmail.Text;
            string rua = txtRua.Text;
            string n = txtN.Text;
            string bairro = txtBairro.Text;
            string comp = txtComp.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = cboxEstado.Text;

            if (rdFator.IsChecked == true)
            {
                rdfator = "Privado";
            }
            else
            {
                rdfator = "Público";
            }

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=bd_escola;port=3360;user=root;password=root");

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();

                comando.CommandText = "insert into Escola values(null, @nome, @razao, @cnpj, @insc," +
                    " @tipo, @datacri, @responsavel, @responsaveltele, @email, @telefone," +
                    " @rua, @numero, @bairro, @complemento, @cep, @cidade, @estado);";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@razao", razao);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@insc", insc);
                comando.Parameters.AddWithValue("@tipo", rdfator);
                comando.Parameters.AddWithValue("@datacri", datacriacao);
                comando.Parameters.AddWithValue("@responsavel", nome2);
                comando.Parameters.AddWithValue("@responsaveltele", telefone2);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@telefone", telefone3);
                comando.Parameters.AddWithValue("@rua", rua);
                comando.Parameters.AddWithValue("@numero", n);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", comp);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);

                var resultado = comando.ExecuteNonQuery();
                
                if (resultado > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
