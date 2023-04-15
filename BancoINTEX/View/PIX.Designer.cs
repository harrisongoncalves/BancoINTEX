namespace BancoINTEX.View
{
    partial class PIX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIX));
            this.btnPagar = new System.Windows.Forms.Button();
            this.mtxbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxbValor = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Crimson;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Mohave", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPagar.Location = new System.Drawing.Point(9, 128);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(91, 39);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // mtxbCPF
            // 
            this.mtxbCPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxbCPF.Font = new System.Drawing.Font("ADAM.CG PRO", 12F, System.Drawing.FontStyle.Bold);
            this.mtxbCPF.ForeColor = System.Drawing.Color.Black;
            this.mtxbCPF.Location = new System.Drawing.Point(9, 34);
            this.mtxbCPF.Mask = "000.000.000-00";
            this.mtxbCPF.Name = "mtxbCPF";
            this.mtxbCPF.Size = new System.Drawing.Size(160, 23);
            this.mtxbCPF.TabIndex = 10;
            // 
            // mtxbValor
            // 
            this.mtxbValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxbValor.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbValor.ForeColor = System.Drawing.Color.Black;
            this.mtxbValor.Location = new System.Drawing.Point(8, 92);
            this.mtxbValor.Name = "mtxbValor";
            this.mtxbValor.Size = new System.Drawing.Size(160, 30);
            this.mtxbValor.TabIndex = 11;
            this.mtxbValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxbValor_MaskInputRejected);
            this.mtxbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbValor_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Crimson;
            this.btnSair.Location = new System.Drawing.Point(148, -6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 39);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mohave", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mohave", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPF";
            // 
            // PIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(179, 174);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mtxbValor);
            this.Controls.Add(this.mtxbCPF);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PIX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIX";
            this.Load += new System.EventHandler(this.PIX_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PIX_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PIX_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.MaskedTextBox mtxbCPF;
        private System.Windows.Forms.MaskedTextBox mtxbValor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}