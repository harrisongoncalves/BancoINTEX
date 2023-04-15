using BancoINTEX.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Point lastLocation;

        private void Banco_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Banco_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DEPBoleto depBoleto = new DEPBoleto();
            depBoleto.Show();
        }

        private void btnPIX_Click(object sender, EventArgs e)
        {
            PIX pix = new PIX(controle);
            pix.Show();
        }
    }
}