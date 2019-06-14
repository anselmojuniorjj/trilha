using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jogoTrilha.View;

namespace jogoTrilha
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // Jogar jogar = new Jogar();            
            // jogar.ShowDialog();
            
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            Regras regras = new Regras();
            regras.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
