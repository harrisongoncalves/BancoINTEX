using BancoINTEX.Model;
using System;
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
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
        }
    }
}