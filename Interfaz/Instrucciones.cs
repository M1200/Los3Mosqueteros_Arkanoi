using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void Back(object sender, EventArgs e)
        {
            Arkanoid arkanoid = new Arkanoid();
            arkanoid.Show();
            this.Hide();
        }
    }
}