using BancoINTEX.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BancoINTEX.View
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Conectar();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            SqlCommand cmd = new SqlCommand();
            string cpf = new string(mtxbCPF.Text.Where(char.IsDigit).ToArray());
            string senha = txbSenha.Text;
            controle.PegarCPF(cpf);
            controle.EntrarNaConta(cpf, senha);

            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Por favor, insira seu CPF.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, insira sua senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Banco banco = new Banco(controle);
                    banco.Show();
                    Form1 form = new Form1();
                    form.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Conta não encontrada. Verifique seu CPF e sua senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!controle.mensagem.Equals(""))
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point lastLocation;

        private void Entrar_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Entrar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void mtxbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
