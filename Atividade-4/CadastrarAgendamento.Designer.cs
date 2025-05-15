namespace Atividade_4
{
    partial class CadastrarAgendamento
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
            textBox6 = new TextBox();
            label6 = new Label();
            txt_id = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(526, 189);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 144);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 27;
            label6.Text = "Endereco:";
            // 
            // txt_id
            // 
            txt_id.AutoSize = true;
            txt_id.Location = new Point(222, 94);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(25, 20);
            txt_id.TabIndex = 15;
            txt_id.Text = "id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "nome:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(228, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 229);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 17;
            label3.Text = "Data da Consulta";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(526, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 179);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(526, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 94);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 19;
            label5.Text = "Telefone:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 27);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 21;
            // 
            // CadastrarAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Name = "CadastrarAgendamento";
            Text = "CadastrarAgendamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label6;
        private Label txt_id;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}