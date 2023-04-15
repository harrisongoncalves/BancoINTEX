namespace BancoINTEX.View
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtxbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mohave", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mohave", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("ADAM.CG PRO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.Color.Black;
            this.txbNome.Location = new System.Drawing.Point(10, 88);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(236, 23);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "SENHA";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("ADAM.CG PRO", 12F, System.Drawing.FontStyle.Bold);
            this.txbSenha.ForeColor = System.Drawing.Color.Black;
            this.txbSenha.Location = new System.Drawing.Point(10, 182);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(236, 23);
            this.txbSenha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mohave", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONFIRMAR SENHA";
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfSenha.Font = new System.Drawing.Font("ADAM.CG PRO", 12F, System.Drawing.FontStyle.Bold);
            this.txbConfSenha.ForeColor = System.Drawing.Color.Black;
            this.txbConfSenha.Location = new System.Drawing.Point(10, 232);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.PasswordChar = '*';
            this.txbConfSenha.Size = new System.Drawing.Size(236, 23);
            this.txbConfSenha.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Crimson;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Mohave", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(58, 264);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 43);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtxbCPF
            // 
            this.mtxbCPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxbCPF.Font = new System.Drawing.Font("ADAM.CG PRO", 12F, System.Drawing.FontStyle.Bold);
            this.mtxbCPF.ForeColor = System.Drawing.Color.Black;
            this.mtxbCPF.Location = new System.Drawing.Point(13, 135);
            this.mtxbCPF.Mask = "000.000.000-00";
            this.mtxbCPF.Name = "mtxbCPF";
            this.mtxbCPF.Size = new System.Drawing.Size(233, 23);
            this.mtxbCPF.TabIndex = 2;
            this.mtxbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxbCPF_MaskInputRejected);
            this.mtxbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbCPF_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("ADAM.CG PRO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Crimson;
            this.btnSair.Location = new System.Drawing.Point(228, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 39);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(258, 314);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mtxbCPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbConfSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cadastrar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cadastrar_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtxbCPF;
        private System.Windows.Forms.Button btnSair;
    }
}