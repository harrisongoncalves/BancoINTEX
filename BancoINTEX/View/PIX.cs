using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BancoINTEX.View
{
    public partial class PIX : Form
    {
        public PIX()
        {
            InitializeComponent();
        }

        private void mtxbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }


            if ((e.KeyChar == ',') && (txbNome.Text.IndexOf(',') > -1) && (txbNome.Text.IndexOf(',') < txbNome.SelectionStart || txbNome.Text.IndexOf(',') > txbNome.SelectionStart + txbNome.SelectionLength - 1))
            {
                e.Handled = true;
                return;
            }

            int precision = 2;
            int index = txbNome.Text.IndexOf('.');
            if (index > -1 && txbNome.Text.Length - index > precision && txbNome.SelectionLength == 0)
            {   
                e.Handled = true;
                return;
            }
        }
    }
}
