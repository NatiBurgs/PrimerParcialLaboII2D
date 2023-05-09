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
    public partial class FormVendedorFijarCortes : Form
    {
        Empresa empresa;
        Producto productoNuevo;
        FormVendedor vendedor;
        private string nombreProductoNuevo;
        private int cantidadProducto;
        private int precioProducto;

        public FormVendedorFijarCortes(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        private void FormVendedorFijarCortes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombreProductoNuevo = textBox1.Text;
            cantidadProducto = (int)numericUpDown1.Value;
            precioProducto = int.Parse(textBox2.Text);
            productoNuevo = new Producto(nombreProductoNuevo, precioProducto, cantidadProducto);

            empresa.AgregarProductoNuevo(productoNuevo);

            MessageBox.Show($"Nombre: {nombreProductoNuevo} \n Cantidad: {cantidadProducto} \n Precio: ${precioProducto}");
        }

    }
}
