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
        private string metodoDePago = " ";
        private int cantidadSeleccionado = 0;
        private int precioPorKilo = 0;
        private int montoAPagar;

        public FormVenderAClientes(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        /// <summary>
        /// Se cargan los datos del comprador seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreCliente = empresa.ObtenerNombreCliente(comboBox1.SelectedIndex);
            cliente = empresa.ObtenerDatosCliente(nombreCliente);
            montoCliente = cliente.MontoDisponible;
            apellidoCliente = cliente.Apellido;
            label3.Text = cliente.MontoDisponible.ToString();

        }

        /// <summary>
        /// Se cargan inicialmente el listBox1 y el comboBox1, con sus respectivos datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Al seleccionar un radioButton se cambia el método de pago. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cantidadSeleccionado = (int)numericUpDown1.Value;

            if (radioButton1.Checked)
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadSeleccionado);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Efectivo";
            }
            else if (radioButton2.Checked)
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadSeleccionado);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Débito";
            }
            else
            {
                montoAPagar = cliente.ComprarProducto(precioPorKilo, cantidadSeleccionado, 5);
                label7.Text = montoAPagar.ToString();
                metodoDePago = "Crédito";
            }
        }

        /// <summary>
        /// Al hacer click sobre el button1 se muestra el formulario Vendedor, y éste se pausa. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        /// <summary>
        /// Se realiza la selección del producto, y a partir de ésto se cargan los datos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int productoSeleccionadoIndice = listBox1.SelectedIndex;
            string nombreProductoSeleccionado = empresa.ObtenerProductoPorIndice(productoSeleccionadoIndice);


            productoSeleccionado = empresa.ObtenerProducto(nombreProductoSeleccionado);
            precioPorKilo = productoSeleccionado.PrecioKilo;

            numericUpDown1.Maximum = productoSeleccionado.CantidadDisponible;
            numericUpDown1.Minimum = 0;

            label9.Text = productoSeleccionado.PrecioKilo.ToString();
            label12.Text = productoSeleccionado.CantidadDisponible.ToString();

        }

        /// <summary>
        /// Muestra éste formulario.
        /// </summary>
        public void MostrarFormVenderAClientes()
        {
            this.Show();
        }

        /// <summary>
        /// Al realizar click sobre el button2 se cargará el formulario ticketConfirmacion,
        /// mientras que se pausa éste. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cliente.MontoDisponible >= montoAPagar && montoAPagar > 0 && metodoDePago != " ")
            {
                FormVendedorTicketConfirmacion vendedorConfirmacion = new(this, vendedor, empresa, cliente, productoSeleccionado.NombreProducto, precioPorKilo, cantidadSeleccionado, metodoDePago, montoAPagar);
                vendedorConfirmacion.Show();
                this.Hide();
            }
            else { MessageBox.Show("Monto disponible de cliente es insuficiente para la compra"); }

        }

        /// <summary>
        /// Al realizar click sobre el button3 se reduce el stock de la empresa, y se actualiza 
        /// la listBox2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            Producto productoSeleccionado = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex));
            StringBuilder stringBuilder_2 = new StringBuilder();

            int value = (int)numericUpDown1.Value;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = productoSeleccionado.CantidadDisponible;
            cantidadSeleccionado = value;


            empresa.ReducirStock(productoSeleccionado.NombreProducto, cantidadSeleccionado);
            montoAPagar += cliente.ComprarProducto(productoSeleccionado.PrecioKilo, cantidadSeleccionado);
            label7.Text = montoAPagar.ToString();

            if (cantidadSeleccionado > 0)
            {
                
                cliente.AgregarACarrito(productoSeleccionado, cantidadSeleccionado);

                if (cliente.RetornarListaCarrito != null)
                {
                    listBox2.Items.Clear();
                    foreach (Carrito unidad in cliente.RetornarListaCarrito())
                    {
                        stringBuilder_2.AppendLine($"{unidad.Producto.NombreProducto}  *  ({unidad.Cantidad})");
                        listBox2.Items.Add(stringBuilder_2.ToString());
                        stringBuilder_2.Clear();
                    }
                }

            }
            else { MessageBox.Show("Error! Ingrese cantidad mayor a 0"); }
        }

        /// <summary>
        /// Al realizar click sobre el button4 se quitan el producto seleccionado de la lista
        /// del carrito, y se agregan nuevamente al stock de la empresa. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            Carrito carritoSeleccionado = cliente.ObtenerCarrito(cliente.ObtenerCarritoPorIndice(listBox2.SelectedIndex));
            cliente.QuitarDeCarrito(carritoSeleccionado);
            empresa.DevolverProductoAStock(carritoSeleccionado.Producto.NombreProducto, carritoSeleccionado.Cantidad);

            StringBuilder stringBuilder_2 = new StringBuilder();
            listBox2.Items.Clear();

            montoAPagar -= carritoSeleccionado.Cantidad * carritoSeleccionado.Producto.PrecioKilo;
            label7.Text = montoAPagar.ToString();

            foreach (Carrito unidad in cliente.RetornarListaCarrito())
            {
                stringBuilder_2.AppendLine($"{unidad.Producto.NombreProducto}  *  ({unidad.Cantidad})");
                listBox2.Items.Add(stringBuilder_2.ToString());
                stringBuilder_2.Clear();
            }
        }
    }
}
