using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atividade_4
{
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_form_cadastrar_paciente_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conex =  Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    string sql = @"INSERT INTO pacientes(nome,rg,telefone,endereco,email,nascimento) VALUES (@nome, @rg,@telefone,@endereco,@email,@nascimento)";

                    MySqlCommand cmd = new  MySqlCommand(sql, conex);

                    cmd.Parameters.AddWithValue("@nome", txt_nome_form_cadastro_pacientes.Text);
                    cmd.Parameters.AddWithValue("@rg", txt_rg_form_cadastro_pacientes.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone_form_cadastro_pacientes.Text);
                    cmd.Parameters.AddWithValue("@endereco", txt_endereco_form_cadastro_pacientes.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email_form_cadastro_pacientes.Text);
                    cmd.Parameters.AddWithValue("@nascimento", dtpNascimento_form_cadastro_paciente.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Paciente cadastrado com sucesso!");

                 txt_nome_form_cadastro_pacientes.Clear();
                    txt_rg_form_cadastro_pacientes.Clear();
                    txt_telefone_form_cadastro_pacientes.Clear();
                    txt_endereco_form_cadastro_pacientes.Clear();
                    txt_email_form_cadastro_pacientes.Clear();
                    dtpNascimento_form_cadastro_paciente.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }



            }

        }
    }
}
