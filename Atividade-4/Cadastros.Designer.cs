namespace Atividade_4
{
    partial class Cadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastros));
            Cadastrar_paciente = new TabControl();
            tabPage1 = new TabPage();
            btn_cadastrar_form_cadastrar_paciente = new Button();
            txt_email_form_cadastro_pacientes = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            dtpNascimento_form_cadastro_paciente = new DateTimePicker();
            label3 = new Label();
            txt_endereco_form_cadastro_pacientes = new TextBox();
            label4 = new Label();
            txt_telefone_form_cadastro_pacientes = new TextBox();
            label5 = new Label();
            txt_rg_form_cadastro_pacientes = new TextBox();
            txt_nome_form_cadastro_pacientes = new TextBox();
            tabPage2 = new TabPage();
            btn_cadastrar_form_cadastrar_agenda = new Button();
            label11 = new Label();
            txt_motivo_form_cadastrar_consulta = new TextBox();
            txt_horario_form_cadastrar_consulta = new TextBox();
            label9 = new Label();
            dtp_dataDaConsulta_form_cadastrar_consulta = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            cb_pacientes_form_cadastro_consulta = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            Cadastrar_paciente.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Cadastrar_paciente
            // 
            Cadastrar_paciente.Controls.Add(tabPage1);
            Cadastrar_paciente.Controls.Add(tabPage2);
            Cadastrar_paciente.Location = new Point(2, 29);
            Cadastrar_paciente.Name = "Cadastrar_paciente";
            Cadastrar_paciente.SelectedIndex = 0;
            Cadastrar_paciente.Size = new Size(1226, 454);
            Cadastrar_paciente.TabIndex = 0;
            Cadastrar_paciente.SelectedIndexChanged += Cadastrar_paciente_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(btn_cadastrar_form_cadastrar_paciente);
            tabPage1.Controls.Add(txt_email_form_cadastro_pacientes);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dtpNascimento_form_cadastro_paciente);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txt_endereco_form_cadastro_pacientes);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txt_telefone_form_cadastro_pacientes);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txt_rg_form_cadastro_pacientes);
            tabPage1.Controls.Add(txt_nome_form_cadastro_pacientes);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1218, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar Paciente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_form_cadastrar_paciente
            // 
            btn_cadastrar_form_cadastrar_paciente.BackColor = SystemColors.ActiveCaption;
            btn_cadastrar_form_cadastrar_paciente.ImeMode = ImeMode.NoControl;
            btn_cadastrar_form_cadastrar_paciente.Location = new Point(562, 263);
            btn_cadastrar_form_cadastrar_paciente.Name = "btn_cadastrar_form_cadastrar_paciente";
            btn_cadastrar_form_cadastrar_paciente.Size = new Size(130, 52);
            btn_cadastrar_form_cadastrar_paciente.TabIndex = 55;
            btn_cadastrar_form_cadastrar_paciente.Text = "Cadastrar";
            btn_cadastrar_form_cadastrar_paciente.UseVisualStyleBackColor = false;
            btn_cadastrar_form_cadastrar_paciente.Click += btn_cadastrar_form_cadastrar_paciente_Click;
            // 
            // txt_email_form_cadastro_pacientes
            // 
            txt_email_form_cadastro_pacientes.Location = new Point(594, 211);
            txt_email_form_cadastro_pacientes.Name = "txt_email_form_cadastro_pacientes";
            txt_email_form_cadastro_pacientes.Size = new Size(125, 27);
            txt_email_form_cadastro_pacientes.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(602, 136);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 27;
            label6.Text = "Endereco:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(379, 136);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 26;
            label1.Text = "RG:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(363, 95);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "nome:";
            // 
            // dtpNascimento_form_cadastro_paciente
            // 
            dtpNascimento_form_cadastro_paciente.Location = new Point(586, 169);
            dtpNascimento_form_cadastro_paciente.Name = "dtpNascimento_form_cadastro_paciente";
            dtpNascimento_form_cadastro_paciente.Size = new Size(286, 27);
            dtpNascimento_form_cadastro_paciente.TabIndex = 25;
            dtpNascimento_form_cadastro_paciente.Value = new DateTime(2025, 5, 1, 0, 0, 0, 0);
            dtpNascimento_form_cadastro_paciente.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(422, 174);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 17;
            label3.Text = "Data de Nascimento:";
            // 
            // txt_endereco_form_cadastro_pacientes
            // 
            txt_endereco_form_cadastro_pacientes.Location = new Point(683, 133);
            txt_endereco_form_cadastro_pacientes.Name = "txt_endereco_form_cadastro_pacientes";
            txt_endereco_form_cadastro_pacientes.Size = new Size(189, 27);
            txt_endereco_form_cadastro_pacientes.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(539, 214);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // txt_telefone_form_cadastro_pacientes
            // 
            txt_telefone_form_cadastro_pacientes.Location = new Point(683, 92);
            txt_telefone_form_cadastro_pacientes.Name = "txt_telefone_form_cadastro_pacientes";
            txt_telefone_form_cadastro_pacientes.Size = new Size(189, 27);
            txt_telefone_form_cadastro_pacientes.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(608, 92);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 19;
            label5.Text = "Telefone:";
            // 
            // txt_rg_form_cadastro_pacientes
            // 
            txt_rg_form_cadastro_pacientes.Location = new Point(419, 136);
            txt_rg_form_cadastro_pacientes.Name = "txt_rg_form_cadastro_pacientes";
            txt_rg_form_cadastro_pacientes.Size = new Size(169, 27);
            txt_rg_form_cadastro_pacientes.TabIndex = 22;
            // 
            // txt_nome_form_cadastro_pacientes
            // 
            txt_nome_form_cadastro_pacientes.Location = new Point(419, 92);
            txt_nome_form_cadastro_pacientes.Name = "txt_nome_form_cadastro_pacientes";
            txt_nome_form_cadastro_pacientes.Size = new Size(169, 27);
            txt_nome_form_cadastro_pacientes.TabIndex = 21;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btn_cadastrar_form_cadastrar_agenda);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txt_motivo_form_cadastrar_consulta);
            tabPage2.Controls.Add(txt_horario_form_cadastrar_consulta);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dtp_dataDaConsulta_form_cadastrar_consulta);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cb_pacientes_form_cadastro_consulta);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1218, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastrar Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btn_cadastrar_form_cadastrar_agenda
            // 
            btn_cadastrar_form_cadastrar_agenda.BackColor = SystemColors.ActiveCaption;
            btn_cadastrar_form_cadastrar_agenda.ImeMode = ImeMode.NoControl;
            btn_cadastrar_form_cadastrar_agenda.Location = new Point(549, 210);
            btn_cadastrar_form_cadastrar_agenda.Name = "btn_cadastrar_form_cadastrar_agenda";
            btn_cadastrar_form_cadastrar_agenda.Size = new Size(131, 48);
            btn_cadastrar_form_cadastrar_agenda.TabIndex = 54;
            btn_cadastrar_form_cadastrar_agenda.Text = "Cadastrar";
            btn_cadastrar_form_cadastrar_agenda.UseVisualStyleBackColor = false;
            btn_cadastrar_form_cadastrar_agenda.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(534, 161);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 52;
            label11.Text = "Motivo:";
            // 
            // txt_motivo_form_cadastrar_consulta
            // 
            txt_motivo_form_cadastrar_consulta.Location = new Point(599, 158);
            txt_motivo_form_cadastrar_consulta.Name = "txt_motivo_form_cadastrar_consulta";
            txt_motivo_form_cadastrar_consulta.Size = new Size(296, 27);
            txt_motivo_form_cadastrar_consulta.TabIndex = 53;
            // 
            // txt_horario_form_cadastrar_consulta
            // 
            txt_horario_form_cadastrar_consulta.Location = new Point(361, 161);
            txt_horario_form_cadastrar_consulta.Name = "txt_horario_form_cadastrar_consulta";
            txt_horario_form_cadastrar_consulta.Size = new Size(151, 27);
            txt_horario_form_cadastrar_consulta.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(283, 161);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 33;
            label9.Text = "Horario:";
            // 
            // dtp_dataDaConsulta_form_cadastrar_consulta
            // 
            dtp_dataDaConsulta_form_cadastrar_consulta.Location = new Point(666, 116);
            dtp_dataDaConsulta_form_cadastrar_consulta.Name = "dtp_dataDaConsulta_form_cadastrar_consulta";
            dtp_dataDaConsulta_form_cadastrar_consulta.Size = new Size(309, 27);
            dtp_dataDaConsulta_form_cadastrar_consulta.TabIndex = 32;
            dtp_dataDaConsulta_form_cadastrar_consulta.Value = new DateTime(2025, 5, 15, 15, 51, 23, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(534, 116);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 31;
            label8.Text = "Data da Consulta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(279, 111);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 1;
            label7.Text = "Paciente:";
            // 
            // cb_pacientes_form_cadastro_consulta
            // 
            cb_pacientes_form_cadastro_consulta.FormattingEnabled = true;
            cb_pacientes_form_cadastro_consulta.Location = new Point(361, 111);
            cb_pacientes_form_cadastro_consulta.Name = "cb_pacientes_form_cadastro_consulta";
            cb_pacientes_form_cadastro_consulta.Size = new Size(151, 28);
            cb_pacientes_form_cadastro_consulta.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(562, 28);
            label10.Name = "label10";
            label10.Size = new Size(196, 28);
            label10.TabIndex = 56;
            label10.Text = "Cadastro De Paciente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(524, 30);
            label12.Name = "label12";
            label12.Size = new Size(176, 28);
            label12.TabIndex = 55;
            label12.Text = "Cadastrar Consulta";
            // 
            // Cadastros
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 495);
            Controls.Add(Cadastrar_paciente);
            ImeMode = ImeMode.NoControl;
            Name = "Cadastros";
            Text = "Cadastros";
            Cadastrar_paciente.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Cadastrar_paciente;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txt_email_form_cadastro_pacientes;
        private Label label6;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpNascimento_form_cadastro_paciente;
        private Label label3;
        private TextBox txt_endereco_form_cadastro_pacientes;
        private Label label4;
        private TextBox txt_telefone_form_cadastro_pacientes;
        private Label label5;
        private TextBox txt_rg_form_cadastro_pacientes;
        private TextBox txt_nome_form_cadastro_pacientes;
        private Label label7;
        private ComboBox cb_pacientes_form_cadastro_consulta;
        private DateTimePicker dtp_dataDaConsulta_form_cadastrar_consulta;
        private Label label8;
        private TextBox txt_horario_form_cadastrar_consulta;
        private Label label9;
        private Button btn_cadastrar_form_cadastrar_agenda;
        private Label label11;
        private TextBox txt_motivo_form_cadastrar_consulta;
        private Button btn_cadastrar_form_cadastrar_paciente;
        private Label label10;
        private Label label12;
    }
}