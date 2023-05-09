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
    public partial class FormVendedorReponerStock : Form
    {
        private string productoIngresado;
        private int cantidadAReponer;
        Empresa empresa;
        FormVendedor vendedor;
        public FormVendedorReponerStock(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        private void FormVendedorReponerStock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarTexto(textBox1.Text) & empresa.ValidarProducto(textBox1.Text))
            {
                productoIngresado = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Producto Ingresado no existe");
            }

            if (Validador.ValidarNumeroMayorACero(textBox2.Text))
            {
                cantidadAReponer = int.Parse(textBox2.Text);
            }

            empresa.AgregarProductosEnStock(productoIngresado, cantidadAReponer);
            MessageBox.Show($"Se agregó correctamente {cantidadAReponer} unidades de {productoIngresado}");
        }
    }
}
