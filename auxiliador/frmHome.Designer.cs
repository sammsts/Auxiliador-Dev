namespace auxiliador
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Atualizar demo");
            TreeNode treeNode2 = new TreeNode("Parâmetros");
            TreeNode treeNode3 = new TreeNode("Desenvolvimento", new TreeNode[] { treeNode1, treeNode2 });
            tvHome = new TreeView();
            btnGerarPacoteDemo = new Button();
            backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            progressBarGeraPacote = new ProgressBar();
            lblGeraPacote = new Label();
            SuspendLayout();
            // 
            // tvHome
            // 
            tvHome.Location = new Point(1, 0);
            tvHome.Margin = new Padding(3, 2, 3, 2);
            tvHome.Name = "tvHome";
            treeNode1.Name = "";
            treeNode1.Tag = "AtualizarDemo";
            treeNode1.Text = "Atualizar demo";
            treeNode2.Name = "NoParametro";
            treeNode2.Tag = "Parametros";
            treeNode2.Text = "Parâmetros";
            treeNode3.Name = "";
            treeNode3.Text = "Desenvolvimento";
            tvHome.Nodes.AddRange(new TreeNode[] { treeNode3 });
            tvHome.Size = new Size(166, 338);
            tvHome.TabIndex = 0;
            tvHome.Click += tvHome_Click;
            // 
            // btnGerarPacoteDemo
            // 
            btnGerarPacoteDemo.Location = new Point(383, 113);
            btnGerarPacoteDemo.Margin = new Padding(3, 2, 3, 2);
            btnGerarPacoteDemo.Name = "btnGerarPacoteDemo";
            btnGerarPacoteDemo.Size = new Size(104, 22);
            btnGerarPacoteDemo.TabIndex = 1;
            btnGerarPacoteDemo.Text = "Gerar pacote";
            btnGerarPacoteDemo.UseVisualStyleBackColor = true;
            btnGerarPacoteDemo.Visible = false;
            btnGerarPacoteDemo.Click += btnGerarPacoteDemo_Click;
            // 
            // progressBarGeraPacote
            // 
            progressBarGeraPacote.AccessibleDescription = "";
            progressBarGeraPacote.AccessibleName = "";
            progressBarGeraPacote.Location = new Point(317, 157);
            progressBarGeraPacote.Name = "progressBarGeraPacote";
            progressBarGeraPacote.Size = new Size(236, 18);
            progressBarGeraPacote.TabIndex = 2;
            progressBarGeraPacote.Tag = "";
            progressBarGeraPacote.Visible = false;
            // 
            // lblGeraPacote
            // 
            lblGeraPacote.AutoSize = true;
            lblGeraPacote.Location = new Point(317, 188);
            lblGeraPacote.Name = "lblGeraPacote";
            lblGeraPacote.Size = new Size(0, 15);
            lblGeraPacote.TabIndex = 3;
            lblGeraPacote.Visible = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblGeraPacote);
            Controls.Add(progressBarGeraPacote);
            Controls.Add(btnGerarPacoteDemo);
            Controls.Add(tvHome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHome";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvHome;
        private Button btnGerarPacoteDemo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
        private ProgressBar progressBarGeraPacote;
        private Label lblGeraPacote;
    }
}