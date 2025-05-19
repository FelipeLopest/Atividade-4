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

                    Dictionary<int, string> pacientes = new Dictionary<int, string>();

                while (dr.Read())
                {
                        int id = Convert.ToInt32(dr["id"]);
                        string nome = dr["nome"].ToString();
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
            finally
            {
                conex.Close();
            }

            
            }
        

        private void btn_buscar_form_agenda_Click(object sender, EventArgs e)
        {
            if (cb_pacientes_form_agendas.SelectedItem == null)
                return;

            int pacienteId = ((KeyValuePair<int, string>)cb_pacientes_form_agendas.SelectedItem).Key;

            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
            try
                {
                    conex.Open();

                    string sql = @"SELECT pacientes.id, pacientes.nome, cadastroconsulta.motivo, cadastroconsulta.horario_consulta, cadastroconsulta.data_consulta
                                   FROM pacientes
                                 JOIN cadastroconsulta ON pacientes.id = cadastroconsulta.paciente_id
                                 WHERE pacientes.id = ' "+ pacienteId + @"'
                                  ORDER BY cadastroconsulta.data_consulta DESC
                                 LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conex;


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
            finally
            {
                conex.Close();
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

         

            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir a consulta do paciente '{pacienteSelecionado.Value}'?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);

            try
                {
                    conex.Open();

                  
                    string sqlExcluirConsulta = @"
                DELETE FROM cadastroconsulta
                WHERE id = (
                    SELECT id FROM (
                        SELECT id FROM cadastroconsulta
                        WHERE paciente_id = '" + pacienteId + @"'
                        ORDER BY data_consulta DESC, horario_consulta DESC 
                        LIMIT 1
                    ) AS sub
                )";

                    MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sqlExcluirConsulta;
                cmd.Connection = conex;
             
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Consulta excluída com sucesso!");
                      
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
            finally
            {
                conex.Close();
            }
            
        }

        private void CarregarPacientesComboBox()
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

                    Dictionary<int, string> pacientes = new Dictionary<int, string>();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id"]);
                        string nome = dr["nome"].ToString();
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

                    
                    cb_pacientes_form_agendas.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pacientes: " + ex.Message);
                }
            finally
            {
                conex.Close();
            }
            
        }
    }
}

