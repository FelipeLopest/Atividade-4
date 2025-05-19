using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
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
            string conexao = "Server=localhost;Database=clinica;Uid=root; Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
                try
                {
                    conex.Open();
                    string sql=  "SELECT id ,nome FROM pacientes ORDER BY nome";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conex;
                    MySqlDataReader dr = cmd.ExecuteReader(); 
                   

                    Dictionary<int, string> pacientes = new Dictionary<int, string>(); // dicionario para armazenar os pacientes

                    while (dr.Read()) 
                    {
                        int id = Convert.ToInt32(dr["id"]);
                        string nome = dr["nome"].ToString();
                        pacientes.Add(id, nome);
                    }

                    cb_verificar.DataSource = null; // limpa o DataSource anterior
                    cb_verificar.DataSource = new BindingSource(pacientes, null); 
                    cb_verificar.DisplayMember = "Value"; 
                    cb_verificar.ValueMember = "Key"; 
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
        

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_verificar.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente para buscar.");
                return;
            }

            int pacienteId = ((KeyValuePair<int, string>)cb_verificar.SelectedItem).Key; //Pegue o item selecionado no ComboBox, converta para um KeyValuePair<int, string>, e use apenas a chave (que é o id do paciente).”


            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex = new MySqlConnection(conexao);
            
           
                try
                {
                    conex.Open();
                    string sql = "SELECT id, nome, rg, telefone, endereco, email, nascimento FROM pacientes   WHERE id = " + pacienteId;
                                 
                                   
                    MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conex;
              

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dg_tabela.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar paciente: " + ex.Message);
                }
            finally
            {
                conex.Close();
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

            
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir o paciente '{nomePaciente}'?",
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

                    string sql = "DELETE FROM pacientes WHERE id = " + pacienteId;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conex;
                


                int resultado = cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas

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

            finally
            {
                conex.Close();
            }
            


        }


        
        
            
        
    }
}