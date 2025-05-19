using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
           
        }
        private int progresso = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progresso += 10;
            progressBar1.Value = progresso;

            if (progresso >= 100) 
            {
                timer1.Stop();
                LoginForm login = new LoginForm(); 
                this.Hide();

                login.Show(); 
            }
        }
    }
}
