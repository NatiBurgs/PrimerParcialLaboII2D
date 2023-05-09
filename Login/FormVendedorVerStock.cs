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
    public partial class FormVendedorVerStock : Form
    {
        Empresa empresa;
        FormVendedor vendedor;
        public FormVendedorVerStock(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }
        private void FormVendedorVerStock_Load(object sender, EventArgs e)
        {
            List<Producto> productosEnStock = empresa.MostrarCatalogo();
            StringBuilder stringBuilder = new();

            foreach (Producto item in productosEnStock)
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"{item.NombreProducto} | Cantidad Disponible: {item.CantidadDisponible.ToString()}| $ por Kg: {item.PrecioKilo.ToString()}");

                listBox1.Items.Add(stringBuilder.ToString());

            }

            /*List<Producto> stock = empresa.MostrarCatalogo();
            for (int i = 0; i < stock.Count; i++)
            {
                Producto item = stock[i];
                stringBuilder.Append($"\n {item.NombreProducto} | Cantidad Disponible: {item.CantidadDisponile.ToString()} | $ por Kg: {item.PrecioKilo.ToString()}");
                listBox1.Items.Add(stringBuilder);
            }*/


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
