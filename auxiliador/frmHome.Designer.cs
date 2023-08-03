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
            TreeNode treeNode1 = new TreeNode("Npm's");
            TreeNode treeNode2 = new TreeNode("Desenvolvimento", new TreeNode[] { treeNode1 });
            tvHome = new TreeView();
            btnNpmRunWatch = new Button();
            btnNpmRunBuild = new Button();
            btnNpmRunStart = new Button();
            progressBarNpmStart = new ProgressBar();
            progressBarNpmWatch = new ProgressBar();
            progressBarNpmBuild = new ProgressBar();
            backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // tvHome
            // 
            tvHome.Location = new Point(1, 0);
            tvHome.Name = "tvHome";
            treeNode1.Name = "";
            treeNode1.Text = "Npm's";
            treeNode2.Name = "";
            treeNode2.Text = "Desenvolvimento";
            tvHome.Nodes.AddRange(new TreeNode[] { treeNode2 });
            tvHome.Size = new Size(189, 449);
            tvHome.TabIndex = 0;
            tvHome.Click += tvHome_Click;
            // 
            // btnNpmRunWatch
            // 
            btnNpmRunWatch.Location = new Point(438, 151);
            btnNpmRunWatch.Name = "btnNpmRunWatch";
            btnNpmRunWatch.Size = new Size(119, 29);
            btnNpmRunWatch.TabIndex = 1;
            btnNpmRunWatch.Text = "Npm run watch";
            btnNpmRunWatch.UseVisualStyleBackColor = true;
            btnNpmRunWatch.Visible = false;
            // 
            // btnNpmRunBuild
            // 
            btnNpmRunBuild.Location = new Point(438, 212);
            btnNpmRunBuild.Name = "btnNpmRunBuild";
            btnNpmRunBuild.Size = new Size(119, 29);
            btnNpmRunBuild.TabIndex = 2;
            btnNpmRunBuild.Text = "Npm run build";
            btnNpmRunBuild.UseVisualStyleBackColor = true;
            btnNpmRunBuild.Visible = false;
            // 
            // btnNpmRunStart
            // 
            btnNpmRunStart.Location = new Point(438, 93);
            btnNpmRunStart.Name = "btnNpmRunStart";
            btnNpmRunStart.Size = new Size(119, 29);
            btnNpmRunStart.TabIndex = 3;
            btnNpmRunStart.Text = "Npm run start";
            btnNpmRunStart.UseVisualStyleBackColor = true;
            btnNpmRunStart.Visible = false;
            btnNpmRunStart.Click += btnNpmRunStart_Click;
            // 
            // progressBarNpmStart
            // 
            progressBarNpmStart.Location = new Point(438, 93);
            progressBarNpmStart.Name = "progressBarNpmStart";
            progressBarNpmStart.Size = new Size(125, 29);
            progressBarNpmStart.TabIndex = 4;
            progressBarNpmStart.Visible = false;
            // 
            // progressBarNpmWatch
            // 
            progressBarNpmWatch.Location = new Point(438, 151);
            progressBarNpmWatch.Name = "progressBarNpmWatch";
            progressBarNpmWatch.Size = new Size(125, 29);
            progressBarNpmWatch.TabIndex = 5;
            progressBarNpmWatch.Visible = false;
            // 
            // progressBarNpmBuild
            // 
            progressBarNpmBuild.Location = new Point(438, 212);
            progressBarNpmBuild.Name = "progressBarNpmBuild";
            progressBarNpmBuild.Size = new Size(125, 29);
            progressBarNpmBuild.TabIndex = 6;
            progressBarNpmBuild.Visible = false;
            // 
            // backgroundWorkerProgress
            // 
            backgroundWorkerProgress.DoWork += backgroundWorkerProgress_DoWork;
            backgroundWorkerProgress.ProgressChanged += backgroundWorkerProgress_ProgressChanged;
            backgroundWorkerProgress.RunWorkerCompleted += backgroundWorkerProgress_RunWorkerCompleted;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBarNpmBuild);
            Controls.Add(progressBarNpmWatch);
            Controls.Add(progressBarNpmStart);
            Controls.Add(btnNpmRunStart);
            Controls.Add(btnNpmRunBuild);
            Controls.Add(btnNpmRunWatch);
            Controls.Add(tvHome);
            Name = "frmHome";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvHome;
        private Button btnNpmRunWatch;
        private Button btnNpmRunBuild;
        private Button btnNpmRunStart;
        private ProgressBar progressBarNpmStart;
        private ProgressBar progressBarNpmWatch;
        private ProgressBar progressBarNpmBuild;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
    }
}