using Entidades;


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
        private Empresa empresa;
        private Cliente cliente;
        List<Producto> catalogo;
        FormCompradorInicio inicioComprador;
        Producto productoSeleccionado;


        public FormComprador(Cliente clienteUsuario, Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            cliente = clienteUsuario;
            catalogo = empresa.MostrarCatalogo();
            montoDisponible = cliente.MontoDisponible;
        }

        public FormComprador(FormCompradorInicio inicioComprador, Cliente clienteUsuario, Empresa empresa)
        {
            InitializeComponent();
            this.inicioComprador = inicioComprador;
            this.empresa = empresa;
            cliente = clienteUsuario;
            catalogo = empresa.MostrarCatalogo();
            montoDisponible = cliente.MontoDisponible;
        }
        /// <summary>
        /// Carga el formulario Comprador, el comboBox1, el label10 y label8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormComprador_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in catalogo)
            {
                comboBox1.Items.Add(producto.NombreProducto);
            }
            value = (int)numericUpDown1.Value;

            label10.Text = cliente.Mail;
            label8.Text = montoDisponible.ToString();
        }

        /// <summary>
        /// Actualiza el metodo a pagar y la cantidad a pagar dependiento de el radioButton Checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            value = (int)numericUpDown1.Value;
            cantidadKgSeleccionado = value;

            if (radioButton1.Checked)
            {
                cantidadAPagar = cliente.ComprarProducto(precioKilo, cantidadKgSeleccionado);
                label1.Text = cantidadAPagar.ToString();
                metodoDePago = "Débito";
            }
            else if (radioButton2.Checked)
            {
                cantidadAPagar = cliente.ComprarProducto(precioKilo, cantidadKgSeleccionado, 5);
                label1.Text = cantidadAPagar.ToString();
                metodoDePago = "Crédito";
            }
            else
            {
                cantidadAPagar = cliente.ComprarProducto(precioKilo, cantidadKgSeleccionado);
                label1.Text = cantidadAPagar.ToString();
                metodoDePago = "Efectivo";
            }

        }

        /// <summary>
        /// Al precionar el button1 se carga el formulario de confirmacion o de caso contrario,
        /// aparecerá un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cliente.MontoDisponible > cantidadAPagar) & (empresa.ConsultarStock(nombreDeProducto)))
            {
                empresa.ReducirStock(nombreDeProducto, cantidadKg);

                FormTicketConfirmacion formTicket = new(this, cliente, empresa, productoSeleccionado, cantidadKgSeleccionado, precioKilo, metodoDePago, cantidadAPagar);
                formTicket.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($" El monto disponible es menor al precio final");
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
            inicioComprador.MostrarCompradorIncio();
            this.Hide();
        }

        /// <summary>
        /// Al seleccionar una opcion del comboBox1 se actualizan el precio por KG, y el maximo del numericUpDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int productoSeleccionadoIndice = comboBox1.SelectedIndex;
            string nombreProductoSeleccionado = empresa.ObtenerProductoPorIndice(productoSeleccionadoIndice);
            productoSeleccionado = empresa.ObtenerProducto(nombreProductoSeleccionado);

            nombreDeProducto = productoSeleccionado.NombreProducto;

            precioKilo = productoSeleccionado.PrecioKilo;

            label6.Text = precioKilo.ToString();

            cantidadKg = productoSeleccionado.CantidadDisponible;

            numericUpDown1.Maximum = productoSeleccionado.CantidadDisponible;
            numericUpDown1.Minimum = 0;

        }

    }
}
