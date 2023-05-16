using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Login
{
    public partial class FormCompradorDatosDestinatario : Form
    {
        private Cliente cliente;
        private Empresa empresa;
        private int subtotal;
        private FormComprador formComprador;
        private string nombreYApellido;
        private int telefono;
        private string direccion;
        private string localidad;
        private string provincia;
        private int codigoPostal;
        private int dni;
        private string metodoDePago;
        private string datosDeFacturacion;
        private int totalPagar;
        public FormCompradorDatosDestinatario(FormComprador formComprador, Cliente cliente, Empresa empresa, int subtotal)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.empresa = empresa;
            this.subtotal = subtotal;
            this.formComprador = formComprador;
        }

        /// <summary>
        /// La funcion Load de éste formulario carga la el label14, listbox1 y el comboBox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompradorDatosDestinatario_Load(object sender, EventArgs e)
        {
            label14.Text = subtotal.ToString();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (Carrito item in cliente.RetornarListaCarrito())
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"{item.Producto.NombreProducto}  |  Cant. : {item.Cantidad}");
                listBox1.Items.Add(stringBuilder.ToString());
            }

            comboBox1.Items.Add("Factura B - Consumidor Final");
            comboBox1.Items.Add("Factura B - Monotributo");
        }

        /// <summary>
        /// Carga el método de pago del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                totalPagar = cliente.ComprarProducto(subtotal, "Debito");
                label16.Text = totalPagar.ToString();
                metodoDePago = "Debito";
            }
            else if (radioButton2.Checked)
            {
                totalPagar = cliente.ComprarProducto(subtotal, "Credito");
                label16.Text = totalPagar.ToString();
                metodoDePago = "Credito";
            }
            else
            {
                totalPagar = cliente.ComprarProducto(subtotal, "Efectivo");
                label16.Text = totalPagar.ToString();
                metodoDePago = "Efectivo";
            }
        }

        /// <summary>
        /// Al presionar el button2 se cargará el FormularioComprador, y éste se destruye.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            formComprador.MostrarFormComprador();
            this.Dispose();
        }

        /// <summary>
        /// Al presionar el button1 se cargará el FormTicketConfirmación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            EliminarErrorProvider();
            if (ValidarCamposTexto())
            {
                MessageBox.Show("Se ingresaron los datos correctamente");
                nombreYApellido = textBox1.Text;
                direccion = textBox4.Text;
                localidad = textBox5.Text;
                provincia = textBox3.Text;
                codigoPostal = int.Parse(textBox6.Text);
                dni = int.Parse(textBox7.Text);
                FormTicketConfirmacion ticketConfirmacion = new FormTicketConfirmacion(this, cliente, empresa, nombreYApellido, telefono, provincia, direccion, localidad, codigoPostal, dni, metodoDePago, datosDeFacturacion, totalPagar);
                ticketConfirmacion.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, complete los campos");
            }

        }

        /// <summary>
        /// Selección de los datos de facturación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                datosDeFacturacion = "Factura B - Consumidor Final";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                datosDeFacturacion = "Factura B - Monotributo";
            }
        }

        /// <summary>
        /// Valida los campos que deberían tener números y otros que tienen sólo letras.
        /// </summary>
        /// <returns> true or false</returns>
        private bool ValidarCamposTexto()
        {
            int num;
            bool retorno = true;
            if (textBox1.Text == "" || !SoloLetras(textBox1.Text))
            {
                retorno = false;
                errorProvider1.SetError(textBox1, "Ingresar nombre");
            }
            if (textBox3.Text == "" || !SoloLetras(textBox3.Text))
            {
                retorno = false;
                errorProvider1.SetError(textBox3, "Ingresar Provincia");
            }
            if (textBox4.Text == "")
            {
                retorno = false;
                errorProvider1.SetError(textBox4, "Ingresar Dirección");
            }
            if (textBox5.Text == "" || !SoloLetras(textBox5.Text))
            {
                retorno = false;
                errorProvider1.SetError(textBox5, "Ingresar Localidad");
            }
            if (textBox6.Text == "" || !int.TryParse(textBox6.Text, out num))
            {
                retorno = false;
                errorProvider1.SetError(textBox6, "Ingresar Codigo Postal");
            }
            if (textBox7.Text == "" || !int.TryParse(textBox7.Text, out num))
            {
                retorno = false;
                errorProvider1.SetError(textBox7, "Ingresar DNI");
            }

            return retorno;
        }

        /// <summary>
        /// Elimina el errorProvider1.
        /// </summary>
        private void EliminarErrorProvider()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(textBox4, "");
            errorProvider1.SetError(textBox5, "");
            errorProvider1.SetError(textBox6, "");
            errorProvider1.SetError(textBox7, "");
        }

        /// <summary>
        /// Valida que el textBox sea sólo números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox6.Text, out num))
            {
                errorProvider1.SetError(textBox6, "Ingrese números");
            }
            else
            {
                errorProvider1.SetError(textBox6, "");
            }
        }

        /// <summary>
        /// Valida que el textBox sea sólo números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox7.Text, out num))
            {
                errorProvider1.SetError(textBox7, "Ingrese números");
            }
            else
            {
                errorProvider1.SetError(textBox7, "");
            }
        }

        /// <summary>
        /// Valida que el campo sea solamente de letras.
        /// </summary>
        /// <param name="letra"></param>
        /// <returns>true or false</returns>
        private static bool SoloLetras(string letra)
        {
            foreach (Char ch in letra)
            {
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
