using Npgsql;

namespace auxiliador
{
    public partial class frmHome : Form
    {
        AuxiliadorRepository _auxiliadorRepository = new AuxiliadorRepository();
        Database connection = new Database();
        GitHelper gitHelper = new GitHelper();
        NpmHelper npmHelper = new NpmHelper();
        DotnetHelper dotnetHelper = new DotnetHelper();

        public frmHome()
        {
            InitializeComponent();
        }

        private void tvHome_Click(object sender, EventArgs e)
        {
            if (tvHome.SelectedNode.Text == "Atualizar demo")
            {
                btnGerarPacoteDemo.Visible = true;
            }
            else
            {
                btnGerarPacoteDemo.Visible = false;
            }
        }

        private async void btnGerarPacoteDemo_Click(object sender, EventArgs e)
        {
            Pra_Parametros pra_parametros = BuscaParametroGespam();

            string executablePath = pra_parametros.pra_caminhogespam.Trim();
            string binDirectory = Path.Combine(executablePath, "bin");
            string releaseDirectory = Path.Combine(binDirectory, "Release");

            if (Directory.Exists(releaseDirectory))
            {
                try
                {
                    Directory.Delete(releaseDirectory, true); // true permite excluir subdiretórios e arquivos

                    progressBarGeraPacote.Visible = true;
                    progressBarGeraPacote.Value = 70;
                    lblGeraPacote.Text = "Apagando pasta 'Release'...";
                    lblGeraPacote.Visible = true;

                    MessageBox.Show("Pasta 'Release' foi deletada com sucesso.");

                    progressBarGeraPacote.Visible = false;
                    lblGeraPacote.Visible = false;
                    lblGeraPacote.Text = string.Empty;
                    progressBarGeraPacote.Value = 0;

                    await GeraPacotePublishAsync(executablePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar a pasta 'Release': " + ex.Message);
                }
            }
            else
            {
                await GeraPacotePublishAsync(executablePath);
            }

            string publishPath = Path.Combine(executablePath, "bin", "Release", "net7.0", "publish");

            if (Directory.Exists(publishPath))
            {
                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string outputRarPath = Path.Combine(desktopPath, $@"publish_{DateTime.Now.ToString("ddMMyyyy")}.rar");
                    RarHelper rarHelper = new RarHelper();

                    progressBarGeraPacote.Value = 50;
                    lblGeraPacote.Text = "Gerando pacote, criando arquivo RAR.";
                    progressBarGeraPacote.Visible = true;
                    lblGeraPacote.Visible = true;

                    rarHelper.CreateRarArchive(publishPath, outputRarPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar arquivo RAR: " + ex.Message);
                }

                progressBarGeraPacote.Value = 100;
                lblGeraPacote.Visible = false;
                lblGeraPacote.Text = string.Empty;
                progressBarGeraPacote.Visible = false;
                progressBarGeraPacote.Value = 0;

                MessageBox.Show("Arquivo RAR do pacote criado com sucesso!\nEncontre-o na área de trabalho.");
            }
            else
            {
                MessageBox.Show($"O diretório de publicação não existe: {publishPath}");
            }
        }

        private async Task GeraPacotePublishAsync(string executablePath)
        {
            try
            {
                progressBarGeraPacote.Visible = true;
                progressBarGeraPacote.Value = 0;
                lblGeraPacote.Text = "Executando git pull no projeto...";
                lblGeraPacote.Visible = true;

                await Task.Run(() => gitHelper.GitPull(executablePath));
                progressBarGeraPacote.Value = 33;

                await Task.Run(() => npmHelper.NpmBuild(executablePath));
                lblGeraPacote.Text = "Executando npm run build no projeto...";
                progressBarGeraPacote.Value = 66;

                await Task.Run(() => dotnetHelper.DotnetPublish(executablePath));
                lblGeraPacote.Text = "Executando dotnet publish -c release no projeto...";
                progressBarGeraPacote.Value = 100;

                MessageBox.Show("Pacote gerado com sucesso!");

                progressBarGeraPacote.Visible = false;
                lblGeraPacote.Visible = false;
                progressBarGeraPacote.Value = 0;
                lblGeraPacote.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar pacote publish: " + ex.Message);
            }
        }

        private Pra_Parametros BuscaParametroGespam()
        {
            Pra_Parametros pra_parametros = new Pra_Parametros();

            using (NpgsqlConnection db = connection.AbrirConexao())
            {
                using (NpgsqlCommand command = new NpgsqlCommand($@"SELECT pra_id, usu_idusuario, pra_caminhogespam FROM pra_parametros WHERE usu_idusuario = {Session.Active_Session.idUsuario}", db))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pra_parametros = new Pra_Parametros
                            {
                                pra_id = reader.GetInt32(reader.GetOrdinal("pra_id")),
                                usu_idusuario = reader.GetInt32(reader.GetOrdinal("usu_idusuario")),
                                pra_caminhogespam = reader.GetString(reader.GetOrdinal("pra_caminhogespam"))
                            };
                        }
                    }
                }
            }

            return pra_parametros;
        }
    }
}
