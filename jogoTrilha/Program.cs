using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoTrilha
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Jogar jogar = new Jogar();
            // Application.Run(new Inicial());
            Inicial inicial = new Inicial();
            if (inicial.ShowDialog() == DialogResult.OK)
                Application.Run(new Jogar());

            //Jogar jogar = new Jogar();
           // if (jogar.teste == true)
               // Application.Run(new Jogo());
        }
    }
}
