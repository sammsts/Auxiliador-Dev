using Npgsql;

namespace auxiliador
{
    public partial class frmLogin : Form
    {
        Database connection = new Database();

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool TestarConexao()
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    return true; //Se a conex�o for bem-sucedida, retorna true
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

        private bool VerificarUsuarioExistente(string usuario, string senha)
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "SELECT usu_login, usu_senha FROM usu_usuarios WHERE usu_login = @usuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string loginDb = reader["usu_login"].ToString();
                                string senhaDb = reader["usu_senha"].ToString();

                                // Fa�a a valida��o aqui, comparando o login e a senha com os dados inseridos pelo usu�rio
                                if (usuario == loginDb && senha == senhaDb)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usu�rio existente: " + ex.Message);
                return false;
            }
        }

        private string BuscarCaminhoGespam(int idUsuario)
        {
            string caminhoDoProjeto = string.Empty;

            using (NpgsqlConnection db = connection.AbrirConexao())
            {
                db.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT pra_caminhogespam FROM pra_parametros WHERE usu_idusuario = @Id", db))
                {
                    command.Parameters.AddWithValue("Id", 1); // Substitua 1 pelo ID do usu�rio logado, ou outro crit�rio de busca
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (TestarConexao())
            {
                MessageBox.Show("Conex�o bem sucedida!!!");
            }
            else
            {
                MessageBox.Show("A conex�o com o banco de dados falhou!!!");
            }
        }

        private void btnNpmRunWatch_Click(object sender, EventArgs e)
        {
            //string caminhoDoProjeto = BuscarCaminhoGespam(idUsuario);

            //if (!string.IsNullOrEmpty(caminhoDoProjeto))
            //{
            //    // C�digo para executar o comando npm run watch
            //    // Usar o caminhoDoProjeto para executar o comando
            //    // ...
            //}
            //else
            //{
            //    MessageBox.Show("Caminho do projeto n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void linksignin_Click(object sender, EventArgs e)
        {
            frmSignIn _frmSignIn = new frmSignIn();

            _frmSignIn.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool usuarioExistente = VerificarUsuarioExistente(txtboxUsuarioLogin.Text, txtboxSenhaLogin.Text);
                if (usuarioExistente)
                {
                    //Pr�xima tela
                }
                else
                {
                    MessageBox.Show("Usu�rio n�o cadastrado.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
        }
    }
}