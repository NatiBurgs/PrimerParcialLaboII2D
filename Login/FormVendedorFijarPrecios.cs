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

        /// <summary>
        /// El button2 al ser presionado se muestra el FormVendedor y éste se pausa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        /// <summary>
        /// Carga los datos iniciales de la listBox1 al formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVendedorFijarPrecios_Load(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Producto item in empresa.MostrarStockProductos())
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"{item.NombreProducto}  | Precio Actual Kg: {item.PrecioKilo}");
                listBox1.Items.Add(stringBuilder.ToString());
            }
        }

        /// <summary>
        /// Al realizar click sobre el button1 se cambia el precio de el producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EliminarErrorProvider();
            if (ValidarCampoNum())
            {
                precioNuevo = int.Parse(textBox1.Text);
                productoSeleccionado = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex));

                empresa.CambiarPrecioProducto(productoSeleccionado.NombreProducto, precioNuevo);
                MessageBox.Show($"El producto: {productoSeleccionado.NombreProducto} posee un precio nuevo: {precioNuevo}");

                
                listBox1.Items.Clear();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Producto item in empresa.MostrarStockProductos())
                {
                    stringBuilder.Clear();
                    stringBuilder.AppendLine($"{item.NombreProducto}  | Precio Actual Kg: {item.PrecioKilo}");
                    listBox1.Items.Add(stringBuilder.ToString());
                }
            }
        }

        /// <summary>
        /// Valida que el campo no esté vacio y que sea del tipo entero.
        /// </summary>
        /// <returns></returns>
        public bool ValidarCampoNum()
        {
            int num;
            bool retorno = true;

            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out num))
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
        /// Valida el ingreso de datos sea solamente del tipo entero.
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
    }
}
