namespace auxiliador
{
    partial class frmParametros
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
            txtboxCaminhoGespam = new TextBox();
            lblCaminhoGespam = new Label();
            btnSalvarParametros = new Button();
            linkHome = new LinkLabel();
            SuspendLayout();
            // 
            // txtboxCaminhoGespam
            // 
            txtboxCaminhoGespam.Location = new Point(43, 50);
            txtboxCaminhoGespam.Margin = new Padding(3, 2, 3, 2);
            txtboxCaminhoGespam.Name = "txtboxCaminhoGespam";
            txtboxCaminhoGespam.Size = new Size(190, 23);
            txtboxCaminhoGespam.TabIndex = 0;
            // 
            // lblCaminhoGespam
            // 
            lblCaminhoGespam.AutoSize = true;
            lblCaminhoGespam.Location = new Point(237, 52);
            lblCaminhoGespam.Name = "lblCaminhoGespam";
            lblCaminhoGespam.Size = new Size(203, 15);
            lblCaminhoGespam.TabIndex = 1;
            lblCaminhoGespam.Text = "< Informe o caminho do seu gespam";
            // 
            // btnSalvarParametros
            // 
            btnSalvarParametros.Location = new Point(307, 284);
            btnSalvarParametros.Name = "btnSalvarParametros";
            btnSalvarParametros.Size = new Size(75, 23);
            btnSalvarParametros.TabIndex = 2;
            btnSalvarParametros.Text = "Salvar";
            btnSalvarParametros.UseVisualStyleBackColor = true;
            btnSalvarParametros.Click += btnSalvarParametros_Click;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Location = new Point(612, 15);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(40, 15);
            linkHome.TabIndex = 3;
            linkHome.TabStop = true;
            linkHome.Text = "Home";
            linkHome.Click += linkHome_Click;
            // 
            // frmParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkHome);
            Controls.Add(btnSalvarParametros);
            Controls.Add(lblCaminhoGespam);
            Controls.Add(txtboxCaminhoGespam);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmParametros";
            Text = "Parâmetros";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxCaminhoGespam;
        private Label lblCaminhoGespam;
        private Button btnSalvarParametros;
        private LinkLabel linkHome;
    }
}