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
            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    string sql = @"INSERT INTO pacientes(nome,rg,telefone,endereco,email,nascimento) VALUES (@nome, @rg,@telefone,@endereco,@email,@nascimento)";

                    MySqlCommand cmd = new MySqlCommand(sql, conex);

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cadastrar_paciente.SelectedTab == tabPage2)
            {
                CarregarPacientes();
            }
        }

        private void CarregarPacientes()
        {
            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();
                    string sql = "SELECT id, nome FROM pacientes ORDER BY nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    cb_pacientes_form_cadastro_consulta.DataSource = null;

                    Dictionary<int, string> pacientes = new Dictionary<int, string>();

                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string nome = dr.GetString("nome");
                        pacientes.Add(id, nome);
                    }

                    cb_pacientes_form_cadastro_consulta.DataSource = new BindingSource(pacientes, null);
                    cb_pacientes_form_cadastro_consulta.DisplayMember = "Value";
                    cb_pacientes_form_cadastro_consulta.ValueMember = "Key";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_pacientes_form_cadastro_consulta.SelectedValue == null)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            int pacienteId = ((KeyValuePair<int, string>)cb_pacientes_form_cadastro_consulta.SelectedItem).Key;
            DateTime dataConsulta = dtp_dataDaConsulta_form_cadastrar_consulta.Value.Date;
            string horario = txt_horario_form_cadastrar_consulta.Text.Trim();
            string motivo = txt_motivo_form_cadastrar_consulta.Text.Trim();

            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    string sql = @"INSERT INTO cadastroconsulta(paciente_id, data_consulta, horario_consulta, motivo)
                           VALUES (@paciente_id, @data, @horario, @motivo)";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);

                    cmd.Parameters.AddWithValue("@paciente_id", pacienteId);
                    cmd.Parameters.AddWithValue("@data", dataConsulta);
                    cmd.Parameters.AddWithValue("@horario", horario);
                    cmd.Parameters.AddWithValue("@motivo", motivo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Consulta cadastrada com sucesso!");

                    // Limpa os campos
                    cb_pacientes_form_cadastro_consulta.SelectedIndex = -1;
                    dtp_dataDaConsulta_form_cadastrar_consulta.Value = DateTime.Today;
                    txt_horario_form_cadastrar_consulta.Clear();
                    txt_motivo_form_cadastrar_consulta.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar consulta: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
