using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void inscriptionbutton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Arkanoid arkanoid = new Arkanoid();
            arkanoid.Show();
            this.Hide();
        }
    }
}