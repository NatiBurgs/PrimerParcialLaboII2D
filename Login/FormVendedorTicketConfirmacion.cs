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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cliente.MontoDisponible > totalAbonar && empresa.ObtenerProducto(nombreProducto).CantidadDisponible > 0)
            {
                empresa.ReducirStock(nombreProducto, cantidadSeleccionada);
                Factura facturaNueva = new Factura(cliente.Nombre, metodoDePago, totalAbonar, nombreProducto, cantidadSeleccionada);
                empresa.AgregarFacturas(facturaNueva);
                empresa.ObtenerDatosCliente(cliente.Nombre).MontoDisponible -= totalAbonar;
                vendedor.MostrarFormVendedor();

                this.Dispose();
            }
            else
            {
                MessageBox.Show($"Venta Rechazada: \n - Monto disponible de cliente menor al valor de la compra. \n - Stock menor al solicitado");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendedorAClientes.MostrarFormVenderAClientes();
            this.Dispose();
        }
    }
}
