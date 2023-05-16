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
    public partial class FormVendedorReponerStock : Form
    {
        private int cantidadAReponer;
        Empresa empresa;
        FormVendedor vendedor;
        Producto productoSeleccionado;
        public FormVendedorReponerStock(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        /// <summary>
        /// Al realizar click sobre el button2 se mostrará el formVendedor y éste se pausará.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

        /// <summary>
        /// Carga los datos del listbox1 y los demás elementos del formulario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVendedorReponerStock_Load(object sender, EventArgs e)
        {
            List<Producto> productoList = empresa.MostrarStockProductos();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Producto item in productoList)
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"{item.NombreProducto}  | Cantidad Actual: {item.CantidadDisponible}");
                listBox1.Items.Add(stringBuilder.ToString());
            }
        }

        /// <summary>
        /// Al hacer click sobre el button1, se agrega el producto a la lista de stock de la emrpesa. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EliminarErrorProvider();
            if (ValidarCampoNum())
            {
                cantidadAReponer = int.Parse(textBox2.Text);
                productoSeleccionado = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex));
                empresa.AgregarProductosEnStock(productoSeleccionado.NombreProducto, cantidadAReponer);
                MessageBox.Show($"Se agregó correctamente {cantidadAReponer} unidades de {productoSeleccionado.NombreProducto}");
                listBox1.Items.Clear();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Producto item in empresa.MostrarStockProductos())
                {
                    stringBuilder.Clear();
                    stringBuilder.AppendLine($"{item.NombreProducto}  | Cantidad Actual: {item.CantidadDisponible}");
                    listBox1.Items.Add(stringBuilder.ToString());
                }
            }

        }

        /// <summary>
        /// Valida que el ingreso del dato no sea vacío y solamente de numeros enteros. 
        /// </summary>
        /// <returns>true or false</returns>
        public bool ValidarCampoNum()
        {
            int num;
            bool retorno = true;

            if (textBox2.Text == "" || !int.TryParse(textBox2.Text, out num))
            {
                retorno = false;
                errorProvider1.SetError(textBox2, "Ingresar cantidad");
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el campo solamente sea de tipo entero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox2.Text, out num))
            {
                errorProvider1.SetError(textBox2, "Ingrese números");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        /// <summary>
        /// Elimina el mensaje del errorProvider1.
        /// </summary>
        private void EliminarErrorProvider()
        {
            errorProvider1.SetError(textBox2, "");
        }
    }
}
