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

        /// <summary>
        /// Se inicializa el Formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVendedor_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Al realizar click sobre el button1 se genera el FormularioVenderAClientes, y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FormVenderAClientes formVenderAClientes = new FormVenderAClientes(this, empresa);
            formVenderAClientes.Show();
            this.Hide();
        }

        /// <summary>
        /// Al realizar click sobre el button1 se genera el FormVendedorStock, y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormVendedorVerStock formVendedorVerStock = new FormVendedorVerStock(this, empresa);
            formVendedorVerStock.Show();
            this.Hide();
        }

        /// <summary>
        /// Al realizar click sobre el button1 se genera el FormVendedorReponerStock, y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            FormVendedorReponerStock formVendedorReponerStock = new FormVendedorReponerStock(this, empresa);
            formVendedorReponerStock.Show();
            this.Hide();
        }

        /// <summary>
        /// Al realizar click sobre el button1 se genera el FormVendedorFijarPrecios, y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FormVendedorFijarPrecios formVendedorFijarPrecios = new(this, empresa);
            formVendedorFijarPrecios.Show();
            this.Hide();
        }

        /// <summary>
        /// Al realizar click sobre el button1 se genera el FormVendedorFijarCortes, y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FormVendedorFijarCortes formVendedorFijarCortes = new FormVendedorFijarCortes(this, empresa);
            formVendedorFijarCortes.Show();
            this.Hide();
        }

        /// <summary>
        /// Se muestra éste formulario.
        /// </summary>
        public void MostrarFormVendedor()
        {
            this.Show();
        }

        /// <summary>
        /// Se muestra el formulario Login y éste se destruye.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.MostrarLogin();
            this.Dispose();
        }

        /// <summary>
        /// Al hacer click sobre el button7 se abre el FormVendedorFacturas y éste se queda pausado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            FormVendedorFacturas formFacturas = new FormVendedorFacturas(this, empresa);
            formFacturas.Show();
            this.Hide();
        }
    }
}
