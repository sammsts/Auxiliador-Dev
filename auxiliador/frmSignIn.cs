using Npgsql;

namespace auxiliador
{
    public partial class frmSignIn : Form
    {
        Database connection = new Database();
        frmLogin _frmLogin = new frmLogin();

        public frmSignIn()
        {
            InitializeComponent();
        }

        private bool VerificarUsuarioExistente(string usuario)
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "SELECT COUNT(*) FROM usu_usuarios WHERE usu_login = @usuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usuário existente: " + ex.Message);
                return false;
            }
        }

        private void CadastrarUsuario(string nomeCompleto, string usuario, string senha)
        {
            try
            {
                bool usuarioExistente = VerificarUsuarioExistente(usuario);
                if (usuarioExistente)
                {
                    Console.WriteLine("Usuário já cadastrado!");
                    return;
                }

                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "INSERT INTO usu_usuarios (usu_login, usu_senha, usu_nome) VALUES (@usuario, @senha, @nomeCompleto)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@senha", senha);
                        command.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxNomeCompleto.Text) ||
                string.IsNullOrEmpty(txtboxUsuario.Text) ||
                string.IsNullOrEmpty(txtboxSenha.Text) ||
                string.IsNullOrEmpty(txtboxConfirmSenha.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtboxSenha.Text != txtboxConfirmSenha.Text)
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CadastrarUsuario(txtboxNomeCompleto.Text, txtboxUsuario.Text, txtboxSenha.Text);
                MessageBox.Show("Usuário cadastrado com sucesso!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxNomeCompleto.ResetText();
                txtboxUsuario.ResetText();
                txtboxSenha.ResetText();
                txtboxConfirmSenha.ResetText();
            }
        }

        private void linkLoginBack_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }
    }
}
