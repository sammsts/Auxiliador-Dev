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
            txtboxCaminhoGespam.Location = new Point(49, 67);
            txtboxCaminhoGespam.Name = "txtboxCaminhoGespam";
            txtboxCaminhoGespam.Size = new Size(217, 27);
            txtboxCaminhoGespam.TabIndex = 0;
            // 
            // lblCaminhoGespam
            // 
            lblCaminhoGespam.AutoSize = true;
            lblCaminhoGespam.Location = new Point(271, 69);
            lblCaminhoGespam.Name = "lblCaminhoGespam";
            lblCaminhoGespam.Size = new Size(254, 20);
            lblCaminhoGespam.TabIndex = 1;
            lblCaminhoGespam.Text = "< Informe o caminho do seu gespam";
            // 
            // btnSalvarParametros
            // 
            btnSalvarParametros.Location = new Point(351, 379);
            btnSalvarParametros.Margin = new Padding(3, 4, 3, 4);
            btnSalvarParametros.Name = "btnSalvarParametros";
            btnSalvarParametros.Size = new Size(86, 31);
            btnSalvarParametros.TabIndex = 2;
            btnSalvarParametros.Text = "Salvar";
            btnSalvarParametros.UseVisualStyleBackColor = true;
            btnSalvarParametros.Click += btnSalvarParametros_Click;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Location = new Point(700, 20);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(50, 20);
            linkHome.TabIndex = 3;
            linkHome.TabStop = true;
            linkHome.Text = "Home";
            linkHome.Click += linkHome_Click;
            // 
            // frmParametros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(linkHome);
            Controls.Add(btnSalvarParametros);
            Controls.Add(lblCaminhoGespam);
            Controls.Add(txtboxCaminhoGespam);
            Name = "frmParametros";
            Text = "Parâmetros";
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