using BancoINTEX.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BancoINTEX.View
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
            mtxbCPF.ShortcutsEnabled = false;
            mtxbCPF.MaxLength = 11;
        }

        private void mtxbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtxbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string cpf = new string(mtxbCPF.Text.Where(char.IsDigit).ToArray());
            String mensagem = controle.Cadastrar(cpf, txbNome.Text, txbSenha.Text, txbConfSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(controle.mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
                this.Close();
            }
        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)1)
            {
                e.Handled = false;
            }
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private Point lastLocation;

        private void Cadastrar_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Cadastrar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Conectar();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
