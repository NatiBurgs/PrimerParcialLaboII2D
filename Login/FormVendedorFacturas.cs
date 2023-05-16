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
    public partial class FormVendedorFacturas : Form
    {
        Empresa empresa;
        FormVendedor vendedor;
        public FormVendedorFacturas(FormVendedor vendedor, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.vendedor = vendedor;
        }

        /// <summary>
        /// Se carga en el formulario las facturas a mostrar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFactura_Load(object sender, EventArgs e)
        {
            List<Factura> facturaList = empresa.MostrarFacturas();
            StringBuilder stringBuilder = new();

            foreach (Factura item in facturaList)
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"Orden #{item.Rand}     |     Cliente: {item.NombreDeComprador}     |     Total Abonado $ : {item.MontoTotal.ToString()}      |      Método de Pago:{item.MetodoDePago}");

                listBox1.Items.Add(stringBuilder.ToString());

            }
        }

        /// <summary>
        /// Al realizar click sobre el button1 se mostrará el formulario Vendedor y éste se pausará.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            vendedor.MostrarFormVendedor();
            this.Hide();
        }

    }
}
