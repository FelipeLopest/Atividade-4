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
            using (MySqlConnection conex = Conexao.ObterConexao())
            {
                try
                {
                    conex.Open();
                    string sql = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(sql, conex);
                    cmd.Parameters.AddWithValue("@usuario", txt_usuario_formLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txt_Senha_formLogin.Text);

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

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
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
