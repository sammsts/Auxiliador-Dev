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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(350, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            // 
            // linksignin
            // 
            linksignin.AutoSize = true;
            linksignin.Location = new Point(360, 401);
            linksignin.Name = "linksignin";
            linksignin.Size = new Size(56, 20);
            linksignin.TabIndex = 1;
            linksignin.TabStop = true;
            linksignin.Text = "Sign-in";
            linksignin.Click += linksignin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "User";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linksignin);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            Text = "The top one Brazil auxiliador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel linksignin;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}