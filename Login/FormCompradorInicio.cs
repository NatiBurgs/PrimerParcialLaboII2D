﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormCompradorInicio : Form
    {
        Empresa empresa;
        Cliente cliente;
        FormLogin login;
        int montoIngresado;

        public FormCompradorInicio(FormLogin login, Empresa empresa, Cliente cliente)
        {
            InitializeComponent();
            this.login = login;
            this.empresa = empresa;
            this.cliente = cliente;
        }

        /// <summary>
        /// Incializa el formulario comprador inicio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompradorInicio_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Al ser precionado el button1 se mostrara el formulario comprador si el monto ingresado
        /// por el usario es mayor a cero. De caso contrario se mostrará un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarNumeroMayorACero(textBox1.Text))
            {
                montoIngresado = int.Parse(textBox1.Text);
                cliente.MontoDisponible = montoIngresado;
                FormComprador comprador = new FormComprador(this, cliente, empresa);
                comprador.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Error, ingrese un valor mayor a 0");
            }
        }

        /// <summary>
        /// Activa el formulario de comprador inicio.
        /// </summary>
        public void MostrarCompradorIncio()
        {
            this.Show();
        }

        /// <summary>
        /// Se activa el formulario login y el formulario comprador inicio se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            login.MostrarLogin();
            this.Hide();
        }
    }
}
