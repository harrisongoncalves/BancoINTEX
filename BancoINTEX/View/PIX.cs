using BancoINTEX.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BancoINTEX.View
{
    public partial class PIX : Form
    {
        private Controle controle;
        public PIX(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void mtxbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void PIX_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cpfUsuario = controle.cpfUsuario;
            string cpf = new string(mtxbCPF.Text.Where(char.IsDigit).ToArray());
            if (cpf == cpfUsuario)
            {
                MessageBox.Show("Você não pode transferir para si mesmo.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                float valor = float.Parse(mtxbValor.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtxbValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point lastLocation;

        private void PIX_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void PIX_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void mtxbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if (mtxbValor.Text.Contains(",") || mtxbValor.Text.Length == 0)
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
