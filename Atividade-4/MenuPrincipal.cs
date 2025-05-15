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
            MessageBox.Show("Agendamentos");
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
            Pacientes pacientes = new Pacientes();
            pacientes.Show();
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

            cadastros.TopLevel = false; // MUITO importante: torna o form "filho"
            cadastros.FormBorderStyle = FormBorderStyle.None; // remove bordas e título
            cadastros.Dock = DockStyle.Fill; // ocupa todo o espaço do panel
            panel1.Controls.Add(cadastros);


           
            cadastros.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
