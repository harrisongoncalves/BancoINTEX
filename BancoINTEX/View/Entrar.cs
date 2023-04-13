using BancoINTEX.Model;
using System;
using System.Data;
using System.Data.SqlClient;
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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            SqlCommand cmd = new SqlCommand();
            SQL sql = new SQL();
            string cpf = new string(mtxbCPF.Text.Where(char.IsDigit).ToArray());
            controle.PegarCPF(cpf);
            controle.EntrarNaConta(cpf, txbSenha.Text);

            if (controle.mensagem.Equals(""))
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
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
