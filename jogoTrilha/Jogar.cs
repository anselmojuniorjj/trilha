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
    public partial class Jogar : Form
    {

        Jogador jogador1 = new Jogador();
        Jogador jogador2 = new Jogador();

        public Jogar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtJ1_TextChanged(object sender, EventArgs e)
        {
            jogador1.nome = txtJ1.Text;        
        }

        private void txtJ2_TextChanged(object sender, EventArgs e)
        {
            jogador2.nome = txtJ2.Text;            
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo(jogador1.nome, jogador2.nome);
            jogo.Show();

        }
    }
}
