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

        private void btnNpmRunStart_Click(object sender, EventArgs e)
        {
            progressBarNpmStart.Visible = true;
            btnNpmRunStart.Visible = false;
            string caminhoDoProjeto = _auxiliadorRepository.BuscarCaminhoGespam(Session.Active_Session.idUsuario);

            if (!string.IsNullOrEmpty(caminhoDoProjeto))
            {
                //Configurações para executar o prompt de comando
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

                process.Start();

                process.StandardInput.WriteLine($"cd {caminhoDoProjeto}");
                process.StandardInput.WriteLine("npm run start");

                for (int i = 0; i <= 100; i++)
                {
                    progressBarNpmStart.Value = i;

                    Application.DoEvents();
                }


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
