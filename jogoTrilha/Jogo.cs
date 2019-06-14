using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoTrilha
{
    public partial class Jogo : Form
    {

        public Jogo(string jogador1, string jogador2)
        {
            InitializeComponent();

            if (jogador1 == null)
                lblG1.Text = "Jogador 1";
            else
                lblG1.Text = jogador1;

            if (jogador2 == null)
                lblG2.Text = "Jogador 2";
            else
                lblG2.Text = jogador2;

            // lblG1.Text = jogador1;
            // lblG2.Text = jogador2;
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

        }
    }
}
