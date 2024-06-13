using Npgsql;

namespace auxiliador
{
    public partial class frmParametros : Form
    {
        Database connection = new Database();
        frmHome _frmHome = new frmHome();

        public frmParametros()
        {
            InitializeComponent();
        }

        private void btnSalvarParametros_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sqlCount = "SELECT count(*) FROM pra_parametros WHERE usu_idusuario = @usu_idusuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sqlCount, db))
                    {
                        command.Parameters.AddWithValue("@usu_idusuario", Session.Active_Session.idUsuario);

                        int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                        if (rowsAffected > 0)
                        {
                            AlterarParametros();
                        }
                        else
                        {
                            SalvarParametros();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar parâmetros: " + ex.Message);
            }
        }

        private void SalvarParametros()
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "INSERT INTO pra_parametros (usu_idusuario, pra_caminhogespam) VALUES (@usu_idusuario, @pra_caminhogespam)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usu_idusuario", Session.Active_Session.idUsuario);
                        command.Parameters.AddWithValue("@pra_caminhogespam", txtboxCaminhoGespam.Text);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Parâmetros inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtboxCaminhoGespam.ResetText();
                            _frmHome.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao inserir parâmetros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar parâmetros: " + ex.Message);
            }
        }

        private void AlterarParametros()
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "UPDATE pra_parametros SET pra_caminhogespam = @caminhoGespam WHERE usu_idusuario = @usu_idusuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usu_idusuario", Session.Active_Session.idUsuario);
                        command.Parameters.AddWithValue("@caminhoGespam", txtboxCaminhoGespam.Text);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Parâmetros alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtboxCaminhoGespam.ResetText();
                            _frmHome.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar parâmetros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar parâmetros: " + ex.Message);
            }
        }

        private void linkHome_Click(object sender, EventArgs e)
        {
            _frmHome.Show();
            this.Close();
        }
    }
}
