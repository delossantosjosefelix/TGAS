using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FAcercade : Form
    {
        public FAcercade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                return; // Bloquea el arrastre de la ventana
            }

            base.WndProc(ref m);
        }
    }
}
