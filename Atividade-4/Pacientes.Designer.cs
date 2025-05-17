namespace Atividade_4
{
    partial class Pacientes
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
            label7 = new Label();
            cb_verificar = new ComboBox();
            btn_buscar = new Button();
            dg_tabela = new DataGridView();
            id_paciente = new DataGridViewTextBoxColumn();
            nome_paciente = new DataGridViewTextBoxColumn();
            rg_paciente = new DataGridViewTextBoxColumn();
            tel_paciente = new DataGridViewTextBoxColumn();
            endereco_paciente = new DataGridViewTextBoxColumn();
            email_paciente = new DataGridViewTextBoxColumn();
            nasc_paciente = new DataGridViewTextBoxColumn();
            btn_excluir_paciente = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_tabela).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 407);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 17;
            label7.Text = "Pacientes";
            // 
            // cb_verificar
            // 
            cb_verificar.FormattingEnabled = true;
            cb_verificar.Location = new Point(88, 404);
            cb_verificar.Name = "cb_verificar";
            cb_verificar.Size = new Size(151, 28);
            cb_verificar.TabIndex = 18;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(259, 403);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 19;
            btn_buscar.Text = "Confirmar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dg_tabela
            // 
            dg_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_tabela.Columns.AddRange(new DataGridViewColumn[] { id_paciente, nome_paciente, rg_paciente, tel_paciente, endereco_paciente, email_paciente, nasc_paciente });
            dg_tabela.Location = new Point(22, 42);
            dg_tabela.Name = "dg_tabela";
            dg_tabela.RowHeadersWidth = 51;
            dg_tabela.Size = new Size(921, 216);
            dg_tabela.TabIndex = 20;
            // 
            // id_paciente
            // 
            id_paciente.DataPropertyName = "id";
            id_paciente.HeaderText = "ID";
            id_paciente.MinimumWidth = 6;
            id_paciente.Name = "id_paciente";
            id_paciente.Width = 125;
            // 
            // nome_paciente
            // 
            nome_paciente.DataPropertyName = "nome";
            nome_paciente.HeaderText = "Nome";
            nome_paciente.MinimumWidth = 6;
            nome_paciente.Name = "nome_paciente";
            nome_paciente.Width = 125;
            // 
            // rg_paciente
            // 
            rg_paciente.DataPropertyName = "rg";
            rg_paciente.HeaderText = "RG";
            rg_paciente.MinimumWidth = 6;
            rg_paciente.Name = "rg_paciente";
            rg_paciente.Width = 125;
            // 
            // tel_paciente
            // 
            tel_paciente.DataPropertyName = "telefone";
            tel_paciente.HeaderText = "Telefone";
            tel_paciente.MinimumWidth = 6;
            tel_paciente.Name = "tel_paciente";
            tel_paciente.Width = 125;
            // 
            // endereco_paciente
            // 
            endereco_paciente.DataPropertyName = "endereco";
            endereco_paciente.HeaderText = "Endereço";
            endereco_paciente.MinimumWidth = 6;
            endereco_paciente.Name = "endereco_paciente";
            endereco_paciente.Width = 125;
            // 
            // email_paciente
            // 
            email_paciente.DataPropertyName = "email";
            email_paciente.HeaderText = "Email";
            email_paciente.MinimumWidth = 6;
            email_paciente.Name = "email_paciente";
            email_paciente.Width = 125;
            // 
            // nasc_paciente
            // 
            nasc_paciente.DataPropertyName = "nascimento";
            nasc_paciente.HeaderText = "Data de Nascimento";
            nasc_paciente.MinimumWidth = 6;
            nasc_paciente.Name = "nasc_paciente";
            nasc_paciente.Width = 125;
            // 
            // btn_excluir_paciente
            // 
            btn_excluir_paciente.Location = new Point(370, 403);
            btn_excluir_paciente.Name = "btn_excluir_paciente";
            btn_excluir_paciente.Size = new Size(94, 29);
            btn_excluir_paciente.TabIndex = 21;
            btn_excluir_paciente.Text = "Excluir";
            btn_excluir_paciente.UseVisualStyleBackColor = true;
            btn_excluir_paciente.Click += btn_excluir_paciente_Click;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 569);
            Controls.Add(btn_excluir_paciente);
            Controls.Add(dg_tabela);
            Controls.Add(btn_buscar);
            Controls.Add(cb_verificar);
            Controls.Add(label7);
            Name = "Pacientes";
            Text = "                                            ";
            Load += Pacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dg_tabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private ComboBox cb_verificar;
        private Button btn_buscar;
        private DataGridView dg_tabela;
        private DataGridViewTextBoxColumn id_paciente;
        private DataGridViewTextBoxColumn nome_paciente;
        private DataGridViewTextBoxColumn rg_paciente;
        private DataGridViewTextBoxColumn tel_paciente;
        private DataGridViewTextBoxColumn endereco_paciente;
        private DataGridViewTextBoxColumn email_paciente;
        private DataGridViewTextBoxColumn nasc_paciente;
        private Button btn_excluir_paciente;
    }
}