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
    public partial class FormVendedorTicketConfirmacion : Form
    {

        private string nombreProducto;
        private int precioKg;
        private int cantidadSeleccionada;
        private string metodoDePago;
        private int totalAbonar;
        FormVendedor vendedor;
        FormVenderAClientes vendedorAClientes;
        Empresa empresa;
        Cliente cliente;

        public FormVendedorTicketConfirmacion(FormVenderAClientes vendedorAClientes, FormVendedor vendedor, Empresa empresa, Cliente cliente, string nombreProducto, int precioKg, int cantidadSeleccionada, string metodoDePago, int totalAbonar)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedorAClientes = vendedorAClientes;
            this.vendedor = vendedor;
            this.cliente = cliente;

            this.nombreProducto = nombreProducto;
            this.precioKg = precioKg;
            this.cantidadSeleccionada = cantidadSeleccionada;
            this.metodoDePago = metodoDePago;
            this.totalAbonar = totalAbonar;
        }

        /// <summary>
        /// Carga los elementos del formulario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVendedorTicketConfirmacion_Load(object sender, EventArgs e)
        {
            label5.Text = cliente.Nombre;
            label6.Text = cliente.Apellido;
            label7.Text = cliente.Mail;
            label8.Text = cliente.MontoDisponible.ToString();

            label15.Text = nombreProducto;
            label16.Text = precioKg.ToString();
            label17.Text = cantidadSeleccionada.ToString();
            label18.Text = metodoDePago;

            label14.Text = totalAbonar.ToString();
        }

        /// <summary>
        /// Al realizar click sobre el button1 se confirma la venta. Disminuyendo el stock de la 
        /// empresa, y generando una factura nueva. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            empresa.ReducirStock(nombreProducto, cantidadSeleccionada);
            Factura facturaNueva = new Factura(cliente.Nombre, metodoDePago, totalAbonar, nombreProducto, cantidadSeleccionada);
            empresa.AgregarFacturas(facturaNueva);
            empresa.ObtenerDatosCliente(cliente.Nombre).MontoDisponible -= totalAbonar;
            vendedor.MostrarFormVendedor();
            cliente.RetornarListaCarrito().Clear();
            MessageBox.Show("Venta Exitosa! ");

            this.Dispose();
        }

        /// <summary>
        /// Al realizar click sobre el button2 se mostrará el formularioVenderAClientes, y
        /// éste se elimina. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            vendedorAClientes.MostrarFormVenderAClientes();
            this.Dispose();
        }
    }
}
