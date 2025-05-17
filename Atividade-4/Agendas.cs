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

        private void btn_excluir_consulta_Click(object sender, EventArgs e)
        {
            if (cb_pacientes_form_agendas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente no ComboBox.");
                return;
            }

            var pacienteSelecionado = (KeyValuePair<int, string>)cb_pacientes_form_agendas.SelectedItem;
            int pacienteId = pacienteSelecionado.Key;

            // Se você tem um campo txtIdConsulta ou outro para identificar a consulta, use ele:
            // Exemplo: int consultaId = Convert.ToInt32(txtIdConsulta.Text);
            // Caso contrário, vou sugerir excluir a consulta mais recente.

            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir a consulta do paciente '{pacienteSelecionado.Value}'?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    // Excluir a consulta mais recente desse paciente
                    string sqlExcluirConsulta = @"
                DELETE FROM cadastroconsulta
                WHERE id = (
                    SELECT id FROM (
                        SELECT id FROM cadastroconsulta
                        WHERE paciente_id = @pacienteId 
                        ORDER BY data_consulta DESC, horario_consulta DESC 
                        LIMIT 1
                    ) AS sub
                )";

                    MySqlCommand cmd = new MySqlCommand(sqlExcluirConsulta, conex);
                    cmd.Parameters.AddWithValue("@pacienteId", pacienteId);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Consulta excluída com sucesso!");
                        // Aqui você pode chamar o método para atualizar os campos da consulta e/ou recarregar o ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma consulta encontrada para excluir.");
                    }

                    CarregarPacientesComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir consulta: " + ex.Message);
                }
            }
        }

        private void CarregarPacientesComboBox()
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

                    txt_id_form_agendas.Clear();
                    txt_nome_form_agendas.Clear();
                    txt_motivo_form_agendas.Clear();
                    txt_horario_form_agendas.Clear();
                    dtp_dataConsulta_form_agendas.Value = DateTime.Today;

                    // Opcional: deseleciona o ComboBox
                    cb_pacientes_form_agendas.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pacientes: " + ex.Message);
                }
            }
        }
    }
}

