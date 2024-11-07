namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            lab = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 59);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "Administrador de estudiantes";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(47, 140);
            lab.Name = "lab";
            lab.Size = new Size(75, 20);
            lab.TabIndex = 1;
            lab.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 249);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(254, 406);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "inicio";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(43, 177);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 292);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 571);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(lab);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lab;
        private Label label3;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}