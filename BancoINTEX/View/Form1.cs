﻿using System;
using BancoINTEX.View;
using System.Windows.Forms;
using System.Drawing;

namespace BancoINTEX

{
    public partial class Form1 : Form
    {
        private Entrar entrarInstance;
        private Cadastrar cadastrarInstance;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cadastrarInstance == null)
            {
                cadastrarInstance = new Cadastrar();
                cadastrarInstance.FormClosed += CadastrarClosed;
                cadastrarInstance.Show();
            }
            else
            {
                cadastrarInstance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entrarInstance == null)
            {
                entrarInstance = new Entrar();
                entrarInstance.FormClosed += EntrarClosed;
                entrarInstance.Show();
            }
            else
            {
                entrarInstance.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarClosed(object sender, FormClosedEventArgs e)
        {
            cadastrarInstance = null;
        }

        private void EntrarClosed(object sender, FormClosedEventArgs e)
        {
            entrarInstance = null;
        }

        private Point lastLocation;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }
    }
}
