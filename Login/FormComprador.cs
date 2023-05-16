using Entidades;
using System.Text;

namespace Login
{
    public partial class FormComprador : Form
    {
        private string nombreDeProducto = " ";
        private int cantidadKg;
        private int precioKilo;
        private string metodoDePago = "efectivo";
        private int cantidadAPagar;
        private int cantidadKgSeleccionado;
        private int value;
        private int montoDisponible;
        private int subTotal = 0;
        private Empresa empresa;
        private Cliente cliente;
        FormCompradorInicio inicioComprador;



        public FormComprador(Cliente clienteUsuario, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            cliente = clienteUsuario;
            montoDisponible = cliente.MontoDisponible;
        }

        public FormComprador(FormCompradorInicio inicioComprador, Cliente clienteUsuario, Empresa empresa)
        {
            InitializeComponent();
            this.inicioComprador = inicioComprador;
            this.empresa = empresa;
            cliente = clienteUsuario;
            montoDisponible = cliente.MontoDisponible;
        }
        /// <summary>
        /// Carga el formulario Comprador, el comboBox1, el label10 y label8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormComprador_Load(object sender, EventArgs e)
        {

            List<Producto> productoList = empresa.MostrarStockProductos();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Producto item in productoList)
            {
                stringBuilder.Clear();
                stringBuilder.AppendLine($"{item.NombreProducto}");
                listBox1.Items.Add(stringBuilder.ToString());
            }

            label10.Text = cliente.Mail;
            label8.Text = cliente.MontoDisponible.ToString();

        }

        /// <summary>
        /// Al precionar el button1 se carga el formulario de confirmacion o de caso contrario,
        /// aparecerá un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            if (subTotal > 0)
            {

                FormCompradorDatosDestinatario formDestinatario = new FormCompradorDatosDestinatario(this, cliente, empresa, subTotal);
                formDestinatario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Agregue productos al carrito!");
            }
        }

        /// <summary>
        /// Muestra el formulario comprador.
        /// </summary>
        public void MostrarFormComprador()
        {
            this.montoDisponible = cliente.MontoDisponible;
            this.Show();
        }

        /// <summary>
        /// Al precionar el button2 se mostrará el formulario de inicio del comprador.
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
        /// Cambia el valor del indice del elemento según cuál esté seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Text = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex)).CantidadDisponible.ToString();
            label6.Text = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex)).PrecioKilo.ToString();
        }

        /// <summary>
        /// Al hacer click sobre el button3 se agrega el producto seleccinado al carrito
        /// del comprador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = empresa.ObtenerProducto(empresa.ObtenerProductoPorIndice(listBox1.SelectedIndex));
            StringBuilder stringBuilder_2 = new StringBuilder();

            value = (int)numericUpDown1.Value;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = productoSeleccionado.CantidadDisponible;
            cantidadKgSeleccionado = value;


            empresa.ReducirStock(productoSeleccionado.NombreProducto, cantidadKgSeleccionado);
            subTotal += cliente.ComprarProducto(productoSeleccionado.PrecioKilo, cantidadKgSeleccionado);
            label7.Text = subTotal.ToString();

            if (cantidadKgSeleccionado > 0)
            {
                cliente.AgregarACarrito(productoSeleccionado, cantidadKgSeleccionado);
                if (cliente.RetornarListaCarrito != null)
                {
                    listBox2.Items.Clear();
                    foreach (Carrito unidad in cliente.RetornarListaCarrito())
                    {
                        stringBuilder_2.AppendLine($"{unidad.Producto.NombreProducto}  *  ({unidad.Cantidad})");
                        listBox2.Items.Add(stringBuilder_2.ToString());
                        stringBuilder_2.Clear();
                    }
                }

            }
            else { MessageBox.Show("Error! Ingrese cantidad mayor a 0"); }
        }

        /// <summary>
        /// Al realizar click sobre el button4 se eliminará del carrito del comprador
        /// el producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Carrito carritoSeleccionado = cliente.ObtenerCarrito(cliente.ObtenerCarritoPorIndice(listBox2.SelectedIndex));
            cliente.QuitarDeCarrito(carritoSeleccionado);
            empresa.DevolverProductoAStock(carritoSeleccionado.Producto.NombreProducto, carritoSeleccionado.Cantidad);

            StringBuilder stringBuilder_2 = new StringBuilder();
            listBox2.Items.Clear();

            subTotal -= carritoSeleccionado.Cantidad * carritoSeleccionado.Producto.PrecioKilo;
            label7.Text = subTotal.ToString();

            foreach (Carrito unidad in cliente.RetornarListaCarrito())
            {
                stringBuilder_2.AppendLine($"{unidad.Producto.NombreProducto}  *  ({unidad.Cantidad})");
                listBox2.Items.Add(stringBuilder_2.ToString());
                stringBuilder_2.Clear();
            }
        }
    }
}
