namespace BancoINTEX.View
{
    partial class DEPBoleto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEPBoleto));
            this.btnSair = new System.Windows.Forms.Button();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Crimson;
            this.btnSair.Location = new System.Drawing.Point(157, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 39);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValor.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.ForeColor = System.Drawing.Color.Black;
            this.txbValor.Location = new System.Drawing.Point(7, 6);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(145, 30);
            this.txbValor.TabIndex = 17;
            this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValor_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mohave", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(7, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "DEPOSITAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DEPBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(183, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.btnSair);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DEPBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPBoleto";
            this.Load += new System.EventHandler(this.DEPBoleto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DEPBoleto_MouseDown);
            this.MouseEnter += new System.EventHandler(this.DEPBoleto_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DEPBoleto_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button button1;
    }
}