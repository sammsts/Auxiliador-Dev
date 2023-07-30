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
                    db.Open();
                    return true; //Se a conex�o for bem-sucedida, retorna true
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
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

        private void linksignin_Click(object sender, EventArgs e)
        {
            frmSignIn _frmSignIn = new frmSignIn();
            _frmSignIn.Show();
        }
    }
}