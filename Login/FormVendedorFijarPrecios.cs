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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class FormVendedorFijarPrecios : Form
    {
        private Producto productoSeleccionado;
        private int precioNuevo;
        Empresa empresa;
        FormVendedor vendedor;
        public FormVendedorFijarPrecios(FormVendedor vendedor, Empresa empresa)
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

        private void FormVendedorFijarPrecios_Load(object sender, EventArgs e)
        {
            List<Producto> catalogo = new List<Producto>();
            catalogo = empresa.MostrarCatalogo();


            for (int i = 0; i < catalogo.Count; i++)
            {
                Producto item = catalogo[i];
                listBox1.Items.Add(item.NombreProducto);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceProducto = listBox1.SelectedIndex;
            //string producto = listBox1.SelectedIndex.ToString();
            string productoSeleccionadoNombre = empresa.ObtenerProductoPorIndice(indiceProducto);

            productoSeleccionado = empresa.ObtenerProducto(productoSeleccionadoNombre);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarNumeroMayorACero(textBox1.Text))
            {
                precioNuevo = int.Parse(textBox1.Text);
                empresa.CambiarPrecioProducto(productoSeleccionado.NombreProducto, precioNuevo);
                MessageBox.Show($"El producto: {productoSeleccionado.NombreProducto} posee un precio nuevo: {precioNuevo}");
            }
            else { MessageBox.Show("Ingrese un precio mayor a 0"); }

        }
    }
}
