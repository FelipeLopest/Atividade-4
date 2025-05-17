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
        private int progresso = 0; // variável para controlar o progresso da barra
        private void timer1_Tick(object sender, EventArgs e)
        {
            progresso += 10; // cada tick soma 2% (100% em 50 ticks × 50ms = 2,5s)
            progressBar1.Value = progresso; // atualiza a barra de progresso

            if (progresso >= 100 && timer1.Interval ==250)
            {
                timer1.Stop();
                this.Hide();

                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
