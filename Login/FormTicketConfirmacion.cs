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

        private int cantidadKg;
        private int precioKg;
        private string metodoDePago;
        private int cantidadAPagar;
        Cliente cliente;
        Empresa empresa;
        FormComprador comprador;
        Producto productoSeleccionado;

        public FormTicketConfirmacion(FormComprador comprador, Cliente clienteUsuario, Empresa empresa, Producto productoSeleccionado, int cantidadKgUsuario, int precioKgUsuario, string metodoDePagoUsuario, int cantidadAPagar)
        {
            InitializeComponent();
            this.comprador = comprador;
            this.productoSeleccionado = productoSeleccionado;
            cantidadKg = cantidadKgUsuario;
            precioKg = precioKgUsuario;
            metodoDePago = metodoDePagoUsuario;
            cliente = clienteUsuario;
            this.cantidadAPagar = cantidadAPagar;
            this.empresa = empresa;
        }

        private void FormTicketConfirmacion_Load(object sender, EventArgs e)
        {
            label2.Text = cliente.Nombre;
            label3.Text = cliente.Apellido;
            label4.Text = cliente.Mail;
            label19.Text = cliente.MontoDisponible.ToString();

            label5.Text = productoSeleccionado.NombreProducto;
            label6.Text = cantidadKg.ToString();
            label7.Text = precioKg.ToString();
            label10.Text = metodoDePago.ToString();

            label8.Text = cantidadAPagar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comprador.MostrarFormComprador();
            this.Dispose();
        }

        private void FormTicketConfirmacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            comprador.MostrarFormComprador();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cliente.MontoDisponible -= cantidadAPagar;
            empresa.ReducirStock(productoSeleccionado.NombreProducto, cantidadKg);
            MessageBox.Show($"{cliente.MontoDisponible}   Se ha genera su compra!");
            FormComprador formComprador = new FormComprador(cliente, empresa);
            formComprador.MostrarFormComprador();
            this.Dispose();
        }
    }
}
