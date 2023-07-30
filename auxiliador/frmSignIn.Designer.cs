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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 239);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 26;
            label4.Text = "Confirme sua senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 206);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 25;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 176);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 24;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 90);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 23;
            label1.Text = "Nome completo";
            // 
            // txtboxConfirmSenha
            // 
            txtboxConfirmSenha.Location = new Point(263, 239);
            txtboxConfirmSenha.Name = "txtboxConfirmSenha";
            txtboxConfirmSenha.PasswordChar = '*';
            txtboxConfirmSenha.Size = new Size(171, 27);
            txtboxConfirmSenha.TabIndex = 22;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(296, 332);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(94, 29);
            btnSignin.TabIndex = 21;
            btnSignin.Text = "Sign-In";
            btnSignin.UseVisualStyleBackColor = true;
            // 
            // txtboxSenha
            // 
            txtboxSenha.Location = new Point(263, 206);
            txtboxSenha.Name = "txtboxSenha";
            txtboxSenha.PasswordChar = '*';
            txtboxSenha.Size = new Size(171, 27);
            txtboxSenha.TabIndex = 20;
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Location = new Point(263, 173);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(171, 27);
            txtboxUsuario.TabIndex = 19;
            // 
            // txtboxNomeCompleto
            // 
            txtboxNomeCompleto.Location = new Point(233, 116);
            txtboxNomeCompleto.Name = "txtboxNomeCompleto";
            txtboxNomeCompleto.Size = new Size(244, 27);
            txtboxNomeCompleto.TabIndex = 18;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxConfirmSenha);
            Controls.Add(btnSignin);
            Controls.Add(txtboxSenha);
            Controls.Add(txtboxUsuario);
            Controls.Add(txtboxNomeCompleto);
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
    }
}