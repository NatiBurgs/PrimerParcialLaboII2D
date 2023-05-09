using Entidades;
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
    public partial class FormVendedor : Form
    {
        Empresa empresa;
        FormLogin login;
        public FormVendedor(FormLogin login, Empresa empresa)
        {
            InitializeComponent();
            this.login = login;
            this.empresa = empresa;
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVenderAClientes formVenderAClientes = new FormVenderAClientes(this, empresa);
            formVenderAClientes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVendedorVerStock formVendedorVerStock = new FormVendedorVerStock(this, empresa);
            formVendedorVerStock.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVendedorReponerStock formVendedorReponerStock = new FormVendedorReponerStock(this, empresa);
            formVendedorReponerStock.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVendedorFijarPrecios formVendedorFijarPrecios = new(this, empresa);
            formVendedorFijarPrecios.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormVendedorFijarCortes formVendedorFijarCortes = new FormVendedorFijarCortes(this, empresa);
            formVendedorFijarCortes.Show();
            this.Hide();
        }

        public void MostrarFormVendedor()
        {
            this.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login.MostrarLogin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormVendedorFacturas formFacturas = new FormVendedorFacturas(this, empresa);
            formFacturas.Show();
            this.Hide();
        }
    }
}
