using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atividade_4
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            CarregarPacientesNoComboBox();
        }

        private void CarregarPacientesNoComboBox()
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

                    cb_verificar.DataSource = null;
                    cb_verificar.DataSource = new BindingSource(pacientes, null);
                    cb_verificar.DisplayMember = "Value";
                    cb_verificar.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pacientes: " + ex.Message);
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_verificar.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente para buscar.");
                return;
            }

            int pacienteId = ((KeyValuePair<int, string>)cb_verificar.SelectedItem).Key;

            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();
                    string sql = @"SELECT id, nome, rg, telefone, endereco, email, nascimento 
                                   FROM pacientes 
                                   WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    cmd.Parameters.AddWithValue("@id", pacienteId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dg_tabela.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar paciente: " + ex.Message);
                }
            }
        }

        private void btn_excluir_paciente_Click(object sender, EventArgs e)
        {
            if (cb_verificar.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente no ComboBox.");
                return;
            }

            var pacienteSelecionado = (KeyValuePair<int, string>)cb_verificar.SelectedItem;
            int pacienteId = pacienteSelecionado.Key;
            string nomePaciente = pacienteSelecionado.Value;

            // Confirmação
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir o paciente '{nomePaciente}'?",
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

                    string sql = "DELETE FROM pacientes WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    cmd.Parameters.AddWithValue("@id", pacienteId);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Paciente excluído com sucesso!");

                        // Atualizar ComboBox e DataGridView
                        CarregarPacientesNoComboBox(); // recarrega o ComboBox
                        dg_tabela.DataSource = null; // limpa a tabela
                    }
                    else
                    {
                        MessageBox.Show("Paciente não encontrado ou já foi excluído.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir paciente: " + ex.Message);
                }
            }


        }


        private void AtualizarTabela()
        {
            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();

                    string sql = "SELECT id, nome, rg, telefone, endereco, email, nascimento FROM pacientes";
                    MySqlCommand cmd = new MySqlCommand(sql, conex);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dg_tabela.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar tabela: " + ex.Message);
                }
            }
        }
    }
}