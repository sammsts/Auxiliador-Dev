using Npgsql;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace auxiliador
{
    public partial class frmLogin : Form
    {
        private string connectionString = "User ID=postgres;Password=123456;Host=localhost;Port=5433;Database=auxiliador_dev;"; //Máquina Sam


        public frmLogin()
        {
            InitializeComponent();
        }

        public bool TestarConexao()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    return true; //Se a conexão for bem-sucedida, retorna true
                }
            }
            catch (Exception ex)
            {
                //Falha na conexão
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            if (TestarConexao())
            {
                MessageBox.Show("Conexão bem sucedida!!!");
            }
            else
            {
                MessageBox.Show("A conexão com o banco de dados falhou!!!");
            }
        }

        private void btnNpmRunWatch_Click(object sender, EventArgs e)
        {
            //string caminhoDoProjeto = BuscarCaminhoGespam(idUsuario);

            //if (!string.IsNullOrEmpty(caminhoDoProjeto))
            //{
            //    // Código para executar o comando npm run watch
            //    // Usar o caminhoDoProjeto para executar o comando
            //    // ...
            //}
            //else
            //{
            //    MessageBox.Show("Caminho do projeto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private string BuscarCaminhoGespam(int idUsuario)
        {
            string caminhoDoProjeto = string.Empty;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT pra_caminhogespam FROM pra_parametros WHERE usu_idusuario = @Id", connection))
                {
                    command.Parameters.AddWithValue("Id", 1); // Substitua 1 pelo ID do usuário logado, ou outro critério de busca
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            caminhoDoProjeto = reader["CaminhoProjeto"].ToString();
                        }
                    }
                }
            }

            return caminhoDoProjeto;
        }

        private void linksignin_Click(object sender, EventArgs e)
        {
            frmSignIn _frmSignIn = new frmSignIn();
            _frmSignIn.Show();
        }
    }
}