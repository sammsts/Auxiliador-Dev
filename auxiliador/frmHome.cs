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
            if (tvHome.SelectedNode.Text == "Atualizar demo")
            {
                btnGerarPacoteDemo.Visible = true;
            }
            else
            {
                btnGerarPacoteDemo.Visible = false;
            }
        }

        private void btnGerarPacoteDemo_Click(object sender, EventArgs e)
        {
            string executablePath = Application.ExecutablePath;
            string binDirectory = Path.GetDirectoryName(executablePath);
            string releaseDirectory = Path.Combine(binDirectory, "Release");

            if (Directory.Exists(releaseDirectory))
            {
                try
                {
                    Directory.Delete(releaseDirectory, true); // true permite excluir subdiretórios e arquivos
                    MessageBox.Show("Pasta 'Release' foi deletada com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar a pasta 'Release': " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pasta 'Release' não encontrada.");
            }


        }
    }
}
