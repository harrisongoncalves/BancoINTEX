using BancoINTEX.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BancoINTEX.View
{
    public partial class Banco : Form
    {
        private Controle controle;
        public Banco(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void Banco_Load(object sender, EventArgs e)
        {
            string cpf = controle.cpfUsuario;
            SQL sql = new SQL();

            SqlCommand commandConta = new SqlCommand("SELECT conta FROM agenciaBANCO WHERE CPF = @cpf", sql.Conectar());
            commandConta.Parameters.AddWithValue("@cpf", cpf);
            string conta = (string)commandConta.ExecuteScalar();

            SqlCommand commandSaldo = new SqlCommand("SELECT saldo FROM saldoBANCO WHERE CPF = @cpf", sql.Conectar());
            commandSaldo.Parameters.AddWithValue("@cpf", cpf);
            decimal saldo = (decimal)commandSaldo.ExecuteScalar();

            lblConta.Text = conta;
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            PIX pix = new PIX();
            pix.Show();
        }
    }
}
