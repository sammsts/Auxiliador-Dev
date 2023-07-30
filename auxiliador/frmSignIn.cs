using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auxiliador
{
    public partial class frmSignIn : Form
    {
        Database connection = new Database();

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void CadastrarUsuario (string nomeCompleto, string usuario, string senha)
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    db.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO usu_usuarios VALUES ()", db))
                    {
                        command.Parameters.AddWithValue("Id", 1); // Substitua 1 pelo ID do usuário logado, ou outro critério de busca
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //caminhoDoProjeto = reader["CaminhoProjeto"].ToString();
                            }
                        }
                    }
                }
            }
            catch 
            {
            
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            frmSignIn _frmSignIn = new frmSignIn();

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(_frmSignIn.txtboxNomeCompleto.Text) ||
                string.IsNullOrEmpty(_frmSignIn.txtboxUsuario.Text) ||
                string.IsNullOrEmpty(_frmSignIn.txtboxSenha.Text) ||
                string.IsNullOrEmpty(_frmSignIn.txtboxConfirmSenha.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Verifica se a senha e a confirmação de senha coincidem
            else if (_frmSignIn.txtboxSenha.Text != _frmSignIn.txtboxConfirmSenha.Text)
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Todos os campos estão preenchidos e a senha foi confirmada corretamente, segue com o cadastro do usuário
                CadastrarUsuario(_frmSignIn.txtboxNomeCompleto.Text, _frmSignIn.txtboxUsuario.Text, _frmSignIn.txtboxSenha.Text);
            }
        }

    }
}
