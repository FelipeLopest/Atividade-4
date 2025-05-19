using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Agendas agendas = new Agendas();

            agendas.TopLevel = false; 
            agendas.FormBorderStyle = FormBorderStyle.None;
            agendas.Dock = DockStyle.Fill; 
            panel1.Controls.Add(agendas);



            agendas.Show();








        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Hora atual: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://google.com",
                UseShellExecute = true
            });
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Cadastros cadastros = new Cadastros();

            cadastros.TopLevel = false; 
            cadastros.FormBorderStyle = FormBorderStyle.None; // remove bordas e título
            cadastros.Dock = DockStyle.Fill; // ocupa todo o espaço do panel
            panel1.Controls.Add(cadastros);



            cadastros.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pacientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Pacientes pacientes = new Pacientes();


            pacientes.TopLevel = false;
            pacientes.FormBorderStyle = FormBorderStyle.None; 
            pacientes.Dock = DockStyle.Fill; 
            panel1.Controls.Add(pacientes);
            pacientes.Show();
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
