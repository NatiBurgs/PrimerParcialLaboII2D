using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class FormVenderAClientes : Form
    {
        Empresa empresa;
        Cliente cliente = new("null", "null", "null", "null", 0);
        FormVendedor vendedor;
        Producto productoSeleccionado;
        private string nombreCliente = " ";
        private string apellidoCliente = " ";
        private int montoCliente;
        //private string productoSeleccionado = " ";
        private string metodoDePago = " ";
        private int cantidadDeKilos = 0;
        private int precioPorKilo = 0;
        private int montoAPagar;
        private string nombreProductoSeleccionado = " ";

        public FormVenderAClientes(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreCliente = empresa.ObtenerNombreCliente(comboBox1.SelectedIndex);

            cliente = empresa.ObtenerDatosCliente(nombreCliente);
            montoCliente = cliente.MontoDisponible;
            apellidoCliente = cliente.Apellido;
            label3.Text = cliente.MontoDisponible.ToString();

        }

        private void FormVenderAClientes_Load(object sender, EventArgs e)
        {
            List<Producto> catalogo = new();
            catalogo = empresa.MostrarCatalogo();
            foreach (Producto producto in catalogo)
            {
                listBox1.Items.Add(producto.NombreProducto);
            }

            List<Cliente> clientes = new();
            clientes = empresa.MostrarListaClientes();

            foreach (Cliente cliente in clientes)
            {
                comboBox1.Items.Add(cliente.Nombre);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //    numericUpDown1.Maximum = empresa.ObtenerProducto(productoSeleccionado).CantidadDisponible;
            //    numericUpDown1.Minimum = 0;
            //    cantidadDeKilos = Convert.ToInt32(numericUpDown1.Value);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cantidadDeKilos = (int)numericUpDown1.Value;

            if (radioButton1.Checked)
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadDeKilos);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Efectivo";
            }
            else if (radioButton2.Checked)
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadDeKilos);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Débito";
            }
            else
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadDeKilos, 5);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Crédito";
            }


        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            FormVendedorTicketConfirmacion vendedorConfirmacion = new(this, vendedor, empresa, nombreCliente, apellidoCliente, cliente.Mail, cliente.MontoDisponible, productoSeleccionado.NombreProducto, precioPorKilo, cantidadDeKilos, metodoDePago, montoAPagar);

            if (cliente.MontoDisponible > montoAPagar && productoSeleccionado.CantidadDisponible > 0)
            {
                FormVendedorTicketConfirmacion vendedorConfirmacion = new (this, vendedor, empresa, nombreCliente, apellidoCliente, cliente.Mail, cliente.MontoDisponible, productoSeleccionado.NombreProducto, precioPorKilo, cantidadDeKilos, metodoDePago, montoAPagar);
            }
            else
            {

                MessageBox.Show($"Venta Rechazada: \n - Monto disponible de cliente menor al valor de la compra. \n - Stock menor al solicitado");
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int productoSeleccionadoIndice = listBox1.SelectedIndex;
            string nombreProductoSeleccionado = empresa.ObtenerProductoPorIndice(productoSeleccionadoIndice);


            productoSeleccionado = empresa.ObtenerProducto(nombreProductoSeleccionado);
            precioPorKilo = productoSeleccionado.PrecioKilo;

            numericUpDown1.Maximum = productoSeleccionado.CantidadDisponible;
            numericUpDown1.Minimum = 0;

        }

        public void MostrarFormVenderAClientes()
        {
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormVendedorTicketConfirmacion vendedorConfirmacion = new(this, vendedor, empresa, cliente, productoSeleccionado.NombreProducto, precioPorKilo, cantidadDeKilos, metodoDePago, montoAPagar);
            vendedorConfirmacion.Show();
            this.Hide();
        }
    }
}
