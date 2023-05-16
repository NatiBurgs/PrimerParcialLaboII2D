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

        /// <summary>
        /// Al realizar click sobre el button1 se abrirá el FormVendedor y éste se mantiene pausado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        /// <summary>
        /// Se carga el Formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVendedorFijarCortes_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Al realizar click sobre el button2 se agrega un producto nuevo a lista de stock de la empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            EliminarErrorProvider();
            if (ValidarCampoNum())
            {
                nombreProductoNuevo = textBox1.Text;
                cantidadProducto = (int)numericUpDown1.Value;
                precioProducto = int.Parse(textBox2.Text);
                productoNuevo = new Producto(nombreProductoNuevo, precioProducto, cantidadProducto);

                empresa.AgregarProductoNuevo(productoNuevo);

                MessageBox.Show($"Nombre: {nombreProductoNuevo} \n Cantidad: {cantidadProducto} \n Precio: ${precioProducto}");
            }
        }

        /// <summary>
        /// Valida que el campo no esté vacío y sólo posea letras.
        /// </summary>
        /// <returns></returns>
        public bool ValidarCampoNum()
        {

            bool retorno = true;

            if (textBox1.Text == "" || !SoloLetras(textBox1.Text))
            {
                retorno = false;
                errorProvider1.SetError(textBox1, "Ingresar cantidad");
            }
            return retorno;
        }

        /// <summary>
        /// Elimina el mensaje del errorProvider1.
        /// </summary>
        public void EliminarErrorProvider()
        {
            errorProvider1.SetError(textBox1, "");
        }

        /// <summary>
        /// Valida el ingreso de datos numericos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1.Text, out num))
            {
                errorProvider1.SetError(textBox1, "Ingrese números");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        /// <summary>
        /// Valida si el dato es solamente de letras. 
        /// </summary>
        /// <param name="letra"></param>
        /// <returns></returns>
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
