namespace Atividade_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txt_usuario_formLogin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_Senha_formLogin = new TextBox();
            btn_entrar_formLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(478, 79);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txt_usuario_formLogin
            // 
            txt_usuario_formLogin.Location = new Point(463, 151);
            txt_usuario_formLogin.Name = "txt_usuario_formLogin";
            txt_usuario_formLogin.Size = new Size(147, 27);
            txt_usuario_formLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 150);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 195);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // txt_Senha_formLogin
            // 
            txt_Senha_formLogin.Location = new Point(463, 195);
            txt_Senha_formLogin.Name = "txt_Senha_formLogin";
            txt_Senha_formLogin.Size = new Size(147, 27);
            txt_Senha_formLogin.TabIndex = 5;
            // 
            // btn_entrar_formLogin
            // 
            btn_entrar_formLogin.BackColor = SystemColors.ActiveCaption;
            btn_entrar_formLogin.FlatStyle = FlatStyle.Flat;
            btn_entrar_formLogin.Location = new Point(463, 255);
            btn_entrar_formLogin.Name = "btn_entrar_formLogin";
            btn_entrar_formLogin.Size = new Size(137, 48);
            btn_entrar_formLogin.TabIndex = 6;
            btn_entrar_formLogin.Text = "Entrar";
            btn_entrar_formLogin.UseVisualStyleBackColor = false;
            btn_entrar_formLogin.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1022, 518);
            Controls.Add(btn_entrar_formLogin);
            Controls.Add(txt_Senha_formLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_usuario_formLogin);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_usuario_formLogin;
        private Label label2;
        private Label label3;
        private TextBox txt_Senha_formLogin;
        private Button btn_entrar_formLogin;
    }
}