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
    public partial class Agendas : Form
    {
        public Agendas()
        {
            InitializeComponent();
        }

        private void Agendas_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();
                    string sql = "SELECT id, nome FROM pacientes ORDER BY nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    Dictionary<int, string> pacientes = new Dictionary<int, string>();

                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string nome = dr.GetString("nome");
                        pacientes.Add(id, nome);
                    }

                    cb_pacientes_form_agendas.DataSource = null;
                    cb_pacientes_form_agendas.DataSource = new BindingSource(pacientes, null);
                    cb_pacientes_form_agendas.DisplayMember = "Value";
                    cb_pacientes_form_agendas.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pacientes: " + ex.Message);
                }
            }
        }

        private void btn_buscar_form_agenda_Click(object sender, EventArgs e)
        {
            if (cb_pacientes_form_agendas.SelectedItem == null)
                return;

            int pacienteId = ((KeyValuePair<int, string>)cb_pacientes_form_agendas.SelectedItem).Key;

            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    string sql = @"SELECT p.id, p.nome, c.motivo, c.horario_consulta, c.data_consulta 
                           FROM pacientes p
                           JOIN cadastroconsulta c ON p.id = c.paciente_id
                           WHERE p.id = @id
                           ORDER BY c.data_consulta DESC
                           LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    cmd.Parameters.AddWithValue("@id", pacienteId);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txt_id_form_agendas.Text = dr["id"].ToString();
                        txt_nome_form_agendas.Text = dr["nome"].ToString();
                        txt_motivo_form_agendas.Text = dr["motivo"].ToString();
                        txt_horario_form_agendas.Text = dr["horario_consulta"].ToString();
                        dtp_dataConsulta_form_agendas.Value = Convert.ToDateTime(dr["data_consulta"]);
                    }
                    else
                    {
                        MessageBox.Show("Esse paciente ainda não tem consultas cadastradas.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar consulta: " + ex.Message);
                }
            }
        }

        private void cb_pacientes_form_agendas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            }
    }
}

