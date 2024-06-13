namespace auxiliador
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            linksignin = new LinkLabel();
            txtboxUsuarioLogin = new TextBox();
            txtboxSenhaLogin = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(306, 232);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(66, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // linksignin
            // 
            linksignin.AutoSize = true;
            linksignin.Location = new Point(315, 301);
            linksignin.Name = "linksignin";
            linksignin.Size = new Size(45, 15);
            linksignin.TabIndex = 1;
            linksignin.TabStop = true;
            linksignin.Text = "Sign-in";
            linksignin.Click += linksignin_Click;
            // 
            // txtboxUsuarioLogin
            // 
            txtboxUsuarioLogin.Location = new Point(254, 105);
            txtboxUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            txtboxUsuarioLogin.Name = "txtboxUsuarioLogin";
            txtboxUsuarioLogin.PlaceholderText = "User";
            txtboxUsuarioLogin.Size = new Size(182, 23);
            txtboxUsuarioLogin.TabIndex = 2;
            // 
            // txtboxSenhaLogin
            // 
            txtboxSenhaLogin.Location = new Point(254, 130);
            txtboxSenhaLogin.Margin = new Padding(3, 2, 3, 2);
            txtboxSenhaLogin.Name = "txtboxSenhaLogin";
            txtboxSenhaLogin.PlaceholderText = "Password";
            txtboxSenhaLogin.Size = new Size(182, 23);
            txtboxSenhaLogin.TabIndex = 3;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtboxSenhaLogin);
            Controls.Add(txtboxUsuarioLogin);
            Controls.Add(linksignin);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "The top one Brazil auxiliador de devs da Abase Sistemas";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel linksignin;
        private TextBox txtboxUsuarioLogin;
        private TextBox txtboxSenhaLogin;
    }
}