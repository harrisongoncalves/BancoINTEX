using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoINTEX.View
{
    public partial class DEPBoleto : Form
    {
        public DEPBoleto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DEPBoleto_Load(object sender, EventArgs e)
        {

        }

        private Point lastLocation;

        private void DEPBoleto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEPBoleto_MouseEnter(object sender, EventArgs e)
        {

        }

        private void DEPBoleto_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if (txbValor.Text.Contains(",") || txbValor.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)1)
            {
                ((MaskedTextBox)sender).SelectAll();
                e.Handled = true;
            }
        }
    }
}
