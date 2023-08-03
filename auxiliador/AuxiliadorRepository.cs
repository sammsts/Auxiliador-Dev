using Npgsql;

namespace auxiliador
{
    internal class AuxiliadorRepository
    {
        Database connection = new Database();

        public int BuscaIdUsuario(string usuario)
        {
            try
            {
                using (NpgsqlConnection db = connection.AbrirConexao())
                {
                    string sql = "SELECT usu_idusuario FROM usu_usuarios WHERE usu_login = @usuario";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, db))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int Id = Convert.ToInt16(reader["usu_idusuario"]);
                                return Id;
                            }
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usuário existente: " + ex.Message);
                return 0;
            }
        }

        public string BuscarCaminhoGespam(int idUsuario)
        {
            string caminhoDoProjeto = string.Empty;

            using (NpgsqlConnection db = connection.AbrirConexao())
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT pra_caminhogespam FROM pra_parametros WHERE usu_idusuario = @Id", db))
                {
                    command.Parameters.AddWithValue("Id", idUsuario);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            caminhoDoProjeto = reader["pra_caminhogespam"].ToString();
                        }
                    }
                }
            }

            return caminhoDoProjeto;
        }
    }
}
