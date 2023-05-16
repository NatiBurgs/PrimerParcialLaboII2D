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
    public partial class FormTicketConfirmacion : Form
    {
        Cliente cliente;
        Empresa empresa;
        FormCompradorDatosDestinatario formCompradorDatos;
        Random rand = new Random();

        private string nombreYApellido;
        private string provincia;
        private string direccion;
        private string localidad;
        private int codigoPostal;
        private int dni;
        private string metodoDePago;
        private string datosDeFacturacion;
        private int totalPagar;

        public FormTicketConfirmacion(FormCompradorDatosDestinatario formCompradorDatos, Cliente cliente, Empresa empresa, string nombreYApellido, int telefono, string provincia, string direccion, string localidad, int codigoPostal, int dni, string metodoDePago, string datosDeFacturacion, int totalPagar)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.empresa = empresa;
            this.formCompradorDatos = formCompradorDatos;
            this.nombreYApellido = nombreYApellido;
            this.provincia = provincia;
            this.direccion = direccion;
            this.localidad = localidad;
            this.codigoPostal = codigoPostal;
            this.dni = dni;
            this.metodoDePago = metodoDePago;
            this.datosDeFacturacion = datosDeFacturacion;
            this.totalPagar = totalPagar;
        }

        /// <summary>
        /// Carga los datos iniciales del Formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTicketConfirmacion_Load(object sender, EventArgs e)
        {
            label22.Text = rand.Next(0, 10000).ToString();
            label2.Text = nombreYApellido;
            label6.Text = direccion;
            label14.Text = localidad;
            label19.Text = codigoPostal.ToString();
            label16.Text = dni.ToString();
            label4.Text = cliente.Mail;
            label10.Text = metodoDePago.ToString();
            label24.Text = datosDeFacturacion;
            label8.Text = totalPagar.ToString();
            cliente.MontoDisponible += (-totalPagar);
        }

        /// <summary>
        /// Al presionar el button2 se carga el FormLogin, y éste se destruye.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }

        /// <summary>
        /// Al presionar el button1 se eliminará de la lista de stock de la empresa. Y se abre
        /// el FormularioComprador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Carrito carrito in cliente.RetornarListaCarrito())
            {
                empresa.ReducirStock(carrito.Producto.NombreProducto, carrito.Cantidad);
            }
            cliente.RetornarListaCarrito().Clear();

            FormComprador formComprador = new FormComprador(cliente, empresa);
            formComprador.MostrarFormComprador();
            this.Dispose();
        }


    }
}
