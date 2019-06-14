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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            
            Jogar jogar = new Jogar();            
            jogar.ShowDialog();
            
        }
    }
}
