using Npgsql;

public class Database
{
    private string connectionString;

    public Database()
    {
        // Defina aqui a string de conexão
        connectionString = "User ID=postgres;Password=123456;Host=localhost;Port=5433;Database=auxiliador_dev;"; //Máquina Sam
    }

    public NpgsqlConnection AbrirConexao()
    {
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
}

