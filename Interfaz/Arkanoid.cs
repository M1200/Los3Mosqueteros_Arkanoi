using System;

using System.Windows.Forms;

namespace Interfaz
{
    public partial class Arkanoid : Form
    {
        public Arkanoid()
        {
            InitializeComponent();
        }


        private void Play_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();
            this.Hide();
        }


        private void Score_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Show();
            this.Hide();
        }


       
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            Instrucciones instrucciones = new Instrucciones();
            instrucciones.Show();
            this.Hide();
        }
    }
}
