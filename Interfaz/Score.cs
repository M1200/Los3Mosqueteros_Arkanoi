using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void BackScore_Click(object sender, EventArgs e)
        {
            Arkanoid arkanoid = new Arkanoid();
            arkanoid.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arkanoid arkanoid = new Arkanoid();
            arkanoid.Show();
            this.Close();
        }
    }
}