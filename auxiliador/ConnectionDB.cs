using Npgsql;

public class Database
{
    private string connectionString;

    public Database()
    {
#if !DEBUG
        connectionString = "User ID=giqkhphf;Password=33R_MCsErR3u6AoWZ2xiKA9nhjiCz1Qc;Host=motty.db.elephantsql.com;Port=5432;Database=giqkhphf;";
#else
        connectionString = "User ID=postgres;Password=postgre;Host=localhost;Port=5434;Database=AuxiliadorDevLocal;"; //Máquina Sam not
#endif
    }

    public NpgsqlConnection AbrirConexao()
    {
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
}

