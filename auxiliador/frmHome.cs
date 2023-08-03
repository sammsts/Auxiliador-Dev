using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace auxiliador
{
    public partial class frmHome : Form
    {
        AuxiliadorRepository _auxiliadorRepository = new AuxiliadorRepository();
        public frmHome()
        {
            InitializeComponent();
        }

        private void tvHome_Click(object sender, EventArgs e)
        {
            if (tvHome.SelectedNode.Text == "Npm's")
            {
                btnNpmRunStart.Visible = true;
                btnNpmRunWatch.Visible = true;
                btnNpmRunBuild.Visible = true;
            }
            else
            {
                btnNpmRunStart.Visible = false;
                btnNpmRunWatch.Visible = false;
                btnNpmRunBuild.Visible = false;
            }
        }

        private async void btnNpmRunStart_Click(object sender, EventArgs e)
        {
            progressBarNpmStart.Visible = true;
            btnNpmRunStart.Visible = false;
            string caminhoDoProjeto = _auxiliadorRepository.BuscarCaminhoGespam(Session.Active_Session.idUsuario);

            if (!string.IsNullOrEmpty(caminhoDoProjeto))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.OutputDataReceived += (s, outputDataEvent) =>
                {
                    if (!string.IsNullOrEmpty(outputDataEvent.Data))
                    {
                        if (outputDataEvent.Data.Contains("progresso"))
                        {
                            backgroundWorkerProgress.ReportProgress(50);
                        }
                    }
                };

                process.Start();
                process.StandardInput.WriteLine($"cd {caminhoDoProjeto}");
                process.StandardInput.WriteLine("npm run watch");

                await Task.Delay(3000);
                process.StandardInput.WriteLine("");

                process.WaitForExit();

                process.Close();
            }
            else
            {
                MessageBox.Show("O caminho do projeto não foi encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
