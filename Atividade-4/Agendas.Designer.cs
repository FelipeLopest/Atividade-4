namespace Atividade_4
{
    partial class Agendas
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
            textBox7 = new TextBox();
            txt_horario_form_agendas = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dtp_dataConsulta_form_agendas = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            cb_pacientes_form_agendas = new ComboBox();
            btn_buscar_form_agenda = new Button();
            label2 = new Label();
            txt_id_form_agendas = new TextBox();
            label1 = new Label();
            txt_nome_form_agendas = new TextBox();
            label3 = new Label();
            txt_motivo_form_agendas = new TextBox();
            btn_excluir_consulta = new Button();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(311, 335);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(139, 27);
            textBox7.TabIndex = 44;
            // 
            // txt_horario_form_agendas
            // 
            txt_horario_form_agendas.Enabled = false;
            txt_horario_form_agendas.Location = new Point(311, 292);
            txt_horario_form_agendas.Name = "txt_horario_form_agendas";
            txt_horario_form_agendas.Size = new Size(139, 27);
            txt_horario_form_agendas.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Location = new Point(233, 335);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 42;
            label10.Text = "Medico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Location = new Point(233, 292);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 41;
            label9.Text = "Horario";
            // 
            // dtp_dataConsulta_form_agendas
            // 
            dtp_dataConsulta_form_agendas.Enabled = false;
            dtp_dataConsulta_form_agendas.Location = new Point(344, 246);
            dtp_dataConsulta_form_agendas.Name = "dtp_dataConsulta_form_agendas";
            dtp_dataConsulta_form_agendas.Size = new Size(309, 27);
            dtp_dataConsulta_form_agendas.TabIndex = 40;
            dtp_dataConsulta_form_agendas.Value = new DateTime(2025, 5, 15, 15, 51, 23, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(212, 246);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 39;
            label8.Text = "Data da Consulta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 30);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 38;
            label7.Text = "Pacientes ";
            // 
            // cb_pacientes_form_agendas
            // 
            cb_pacientes_form_agendas.FormattingEnabled = true;
            cb_pacientes_form_agendas.Location = new Point(88, 30);
            cb_pacientes_form_agendas.Name = "cb_pacientes_form_agendas";
            cb_pacientes_form_agendas.Size = new Size(151, 28);
            cb_pacientes_form_agendas.TabIndex = 37;
            cb_pacientes_form_agendas.SelectedIndexChanged += cb_pacientes_form_agendas_SelectedIndexChanged;
            // 
            // btn_buscar_form_agenda
            // 
            btn_buscar_form_agenda.Location = new Point(267, 30);
            btn_buscar_form_agenda.Name = "btn_buscar_form_agenda";
            btn_buscar_form_agenda.Size = new Size(94, 29);
            btn_buscar_form_agenda.TabIndex = 45;
            btn_buscar_form_agenda.Text = "Confirmar";
            btn_buscar_form_agenda.UseVisualStyleBackColor = true;
            btn_buscar_form_agenda.Click += btn_buscar_form_agenda_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(267, 104);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 46;
            label2.Text = "id:";
            // 
            // txt_id_form_agendas
            // 
            txt_id_form_agendas.Enabled = false;
            txt_id_form_agendas.Location = new Point(323, 101);
            txt_id_form_agendas.Name = "txt_id_form_agendas";
            txt_id_form_agendas.Size = new Size(125, 27);
            txt_id_form_agendas.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(258, 148);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 48;
            label1.Text = "nome:";
            // 
            // txt_nome_form_agendas
            // 
            txt_nome_form_agendas.Enabled = false;
            txt_nome_form_agendas.Location = new Point(325, 145);
            txt_nome_form_agendas.Name = "txt_nome_form_agendas";
            txt_nome_form_agendas.Size = new Size(125, 27);
            txt_nome_form_agendas.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(258, 201);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 50;
            label3.Text = "Motivo";
            // 
            // txt_motivo_form_agendas
            // 
            txt_motivo_form_agendas.Enabled = false;
            txt_motivo_form_agendas.Location = new Point(323, 198);
            txt_motivo_form_agendas.Name = "txt_motivo_form_agendas";
            txt_motivo_form_agendas.Size = new Size(125, 27);
            txt_motivo_form_agendas.TabIndex = 51;
            // 
            // btn_excluir_consulta
            // 
            btn_excluir_consulta.Location = new Point(367, 30);
            btn_excluir_consulta.Name = "btn_excluir_consulta";
            btn_excluir_consulta.Size = new Size(94, 29);
            btn_excluir_consulta.TabIndex = 53;
            btn_excluir_consulta.Text = "Excluir";
            btn_excluir_consulta.UseVisualStyleBackColor = true;
            btn_excluir_consulta.Click += btn_excluir_consulta_Click;
            // 
            // Agendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_excluir_consulta);
            Controls.Add(label3);
            Controls.Add(txt_motivo_form_agendas);
            Controls.Add(label1);
            Controls.Add(txt_nome_form_agendas);
            Controls.Add(label2);
            Controls.Add(txt_id_form_agendas);
            Controls.Add(btn_buscar_form_agenda);
            Controls.Add(textBox7);
            Controls.Add(txt_horario_form_agendas);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtp_dataConsulta_form_agendas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cb_pacientes_form_agendas);
            Name = "Agendas";
            Text = "Agendas";
            Load += Agendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private TextBox txt_horario_form_agendas;
        private Label label10;
        private Label label9;
        private DateTimePicker dtp_dataConsulta_form_agendas;
        private Label label8;
        private Label label7;
        private ComboBox cb_pacientes_form_agendas;
        private Button btn_buscar_form_agenda;
        private Label label2;
        private TextBox txt_id_form_agendas;
        private Label label1;
        private TextBox txt_nome_form_agendas;
        private Label label3;
        private TextBox txt_motivo_form_agendas;
        private Button btn_excluir_consulta;
    }
}