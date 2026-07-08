using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FBienvenida : Form
    {
        public FBienvenida()
        {
            InitializeComponent();
        }

        private void FBienvenida_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Interval = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;

            if (progressBar1.Value < 30)
                lblMensaje.Text = "Iniciando TreeGames...";
            else if (progressBar1.Value < 60)
                lblMensaje.Text = "Cargando módulos...";
            else if (progressBar1.Value < 90)
                lblMensaje.Text = "Preparando el sistema...";
            else
                lblMensaje.Text = "¡Bienvenido!";

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                FMenu frm = new FMenu();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}