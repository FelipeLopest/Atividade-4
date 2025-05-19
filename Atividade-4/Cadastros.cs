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
            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
            try
                {
                    conex.Open();

                string sql = "INSERT INTO pacientes(nome, rg, telefone, endereco, email, nascimento) VALUES ('"
                + txt_nome_form_cadastro_pacientes.Text + "', '"
                + txt_rg_form_cadastro_pacientes.Text + "', '"
                + txt_telefone_form_cadastro_pacientes.Text + "', '"
                + txt_endereco_form_cadastro_pacientes.Text + "', '"
                + txt_email_form_cadastro_pacientes.Text + "', '"
                 + dtpNascimento_form_cadastro_paciente.Value.ToString("yyyy-MM-dd") + "')";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conex;



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
            finally
            {
                conex.Close();
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
            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
            try
                {
                    conex.Open();
                    string sql = "SELECT id, nome FROM pacientes ORDER BY nome";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conex;
                     MySqlDataReader dr = cmd.ExecuteReader();

                    cb_pacientes_form_cadastro_consulta.DataSource = null;

                    Dictionary<int, string> pacientes = new Dictionary<int, string>();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id"]);
                        string nome = dr["nome"].ToString();
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
            finally
            {
                conex.Close();
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

            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
            try
                {
                    conex.Open();

                string sql = "INSERT INTO cadastroconsulta(paciente_id, data_consulta, horario_consulta, motivo) VALUES ("
                + pacienteId + ", '"
                + dataConsulta + "', '"
                + horario + "', '"
                 + motivo + "')";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conex;


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
            finally
            {
                conex.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
