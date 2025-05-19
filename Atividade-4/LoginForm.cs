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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=clinica;Uid=root;Pwd=";
            MySqlConnection conex  = new MySqlConnection(conexao);
           
            
                try
                {
                    conex.Open();
                    string sql = "SELECT COUNT(*) FROM usuario WHERE usuario = '"+ txt_usuario_formLogin.Text +"' AND senha = '" + txt_Senha_formLogin.Text + "'" ;

                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                   

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar()); // Executa o comando SQL e retorna o número de linhas afetadas

                    if (resultado > 0)
                    {
                        MessageBox.Show("Login efetuado com sucesso!");
                        this.Hide();
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        menuPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }

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
        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
