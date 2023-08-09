using Npgsql;

namespace auxiliador
{
    public partial class frmLogin : Form
    {
        Database connection = new Database();
        frmParametros _frmParametros = new frmParametros();
        frmHome _frmHome = new frmHome();
        AuxiliadorRepository _auxiliadorRepository = new AuxiliadorRepository();

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
                    return true; //Se a conexão for bem-sucedida, retorna true
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

                                // Faça a validação aqui, comparando o login e a senha com os dados inseridos pelo usuário
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
                Console.WriteLine("Erro ao verificar usuário existente: " + ex.Message);
                return false;
            }
        }
        private bool ExisteParametro(int idUsuario)
        {
            try 
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "SELECT count(*) FROM pra_parametros WHERE usu_idusuario = @idusuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@idusuario", idUsuario);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usuário existente: " + ex.Message);
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!TestarConexao())
            {
                MessageBox.Show("A conexão com o banco de dados falhou!!!");
            }
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
                    int idUsuario = _auxiliadorRepository.BuscaIdUsuario(txtboxUsuarioLogin.Text);
                    Session.Active_Session.idUsuario = idUsuario;
                    if (ExisteParametro(idUsuario))
                    {
                        _frmHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        _frmParametros.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
        }
    }
}