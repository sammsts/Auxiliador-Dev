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
            TreeNode treeNode2 = new TreeNode("Desenvolvimento", new TreeNode[] { treeNode1 });
            tvHome = new TreeView();
            btnGerarPacoteDemo = new Button();
            backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // tvHome
            // 
            tvHome.Location = new Point(1, 0);
            tvHome.Name = "tvHome";
            treeNode1.Name = "";
            treeNode1.Text = "Atualizar demo";
            treeNode2.Name = "";
            treeNode2.Text = "Desenvolvimento";
            tvHome.Nodes.AddRange(new TreeNode[] { treeNode2 });
            tvHome.Size = new Size(189, 449);
            tvHome.TabIndex = 0;
            tvHome.Click += tvHome_Click;
            // 
            // btnGerarPacoteDemo
            // 
            btnGerarPacoteDemo.Location = new Point(438, 151);
            btnGerarPacoteDemo.Name = "btnGerarPacoteDemo";
            btnGerarPacoteDemo.Size = new Size(119, 29);
            btnGerarPacoteDemo.TabIndex = 1;
            btnGerarPacoteDemo.Text = "Gerar pacote";
            btnGerarPacoteDemo.UseVisualStyleBackColor = true;
            btnGerarPacoteDemo.Visible = false;
            btnGerarPacoteDemo.Click += btnGerarPacoteDemo_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGerarPacoteDemo);
            Controls.Add(tvHome);
            Name = "frmHome";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvHome;
        private Button btnGerarPacoteDemo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
    }
}