namespace auxiliador
{
    partial class frmSignIn
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtboxConfirmSenha = new TextBox();
            btnSignin = new Button();
            txtboxSenha = new TextBox();
            txtboxUsuario = new TextBox();
            txtboxNomeCompleto = new TextBox();
            linkLoginBack = new LinkLabel();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 179);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 26;
            label4.Text = "Confirme sua senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 154);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 25;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 132);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 24;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 68);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 23;
            label1.Text = "Nome completo";
            // 
            // txtboxConfirmSenha
            // 
            txtboxConfirmSenha.Location = new Point(230, 179);
            txtboxConfirmSenha.Margin = new Padding(3, 2, 3, 2);
            txtboxConfirmSenha.Name = "txtboxConfirmSenha";
            txtboxConfirmSenha.PasswordChar = '*';
            txtboxConfirmSenha.Size = new Size(150, 23);
            txtboxConfirmSenha.TabIndex = 22;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(259, 249);
            btnSignin.Margin = new Padding(3, 2, 3, 2);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(82, 22);
            btnSignin.TabIndex = 21;
            btnSignin.Text = "Sign-In";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // txtboxSenha
            // 
            txtboxSenha.Location = new Point(230, 154);
            txtboxSenha.Margin = new Padding(3, 2, 3, 2);
            txtboxSenha.Name = "txtboxSenha";
            txtboxSenha.PasswordChar = '*';
            txtboxSenha.Size = new Size(150, 23);
            txtboxSenha.TabIndex = 20;
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Location = new Point(230, 130);
            txtboxUsuario.Margin = new Padding(3, 2, 3, 2);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(150, 23);
            txtboxUsuario.TabIndex = 19;
            // 
            // txtboxNomeCompleto
            // 
            txtboxNomeCompleto.Location = new Point(204, 87);
            txtboxNomeCompleto.Margin = new Padding(3, 2, 3, 2);
            txtboxNomeCompleto.Name = "txtboxNomeCompleto";
            txtboxNomeCompleto.Size = new Size(214, 23);
            txtboxNomeCompleto.TabIndex = 18;
            // 
            // linkLoginBack
            // 
            linkLoginBack.AutoSize = true;
            linkLoginBack.Location = new Point(628, 9);
            linkLoginBack.Name = "linkLoginBack";
            linkLoginBack.Size = new Size(37, 15);
            linkLoginBack.TabIndex = 27;
            linkLoginBack.TabStop = true;
            linkLoginBack.Text = "Login";
            linkLoginBack.Click += linkLoginBack_Click;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLoginBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxConfirmSenha);
            Controls.Add(btnSignin);
            Controls.Add(txtboxSenha);
            Controls.Add(txtboxUsuario);
            Controls.Add(txtboxNomeCompleto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSignIn";
            Text = "Sign-In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtboxConfirmSenha;
        private Button btnSignin;
        private TextBox txtboxSenha;
        private TextBox txtboxUsuario;
        private TextBox txtboxNomeCompleto;
        private LinkLabel linkLoginBack;
    }
}