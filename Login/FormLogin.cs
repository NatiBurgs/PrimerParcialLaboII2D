using Entidades;
using Consola;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

namespace Login
{
    public partial class FormLogin : Form
    {
        Empresa Carniceria = new Empresa();

        public FormLogin()
        {
            InitializeComponent();

        }

        /// <summary>
        /// El load carga las listas del objeto Empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Carniceria.CargarVendedores();
            Carniceria.CargarClientes();
            Carniceria.CargarStock();
            Carniceria.CargarFacturas();
        }

        /// <summary>
        /// Al hacer click sobre el button1 se genera el formVendedor o el formCompradorInicio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string mail = textBox1.Text;
            string password = textBox2.Text;


            if (Carniceria.ValidarLoginAVendedores(mail) == true)
            {
                FormVendedor vendedor = new FormVendedor(this,Carniceria);
                vendedor.Show();
                this.Hide();

            }
            else if (Carniceria.ValidarLoginAClientes(mail) == true)
            {
                string nombre = Carniceria.ObtenerNombreCliente(mail);
                string apellido = Carniceria.ObtenerApellidoCliente(mail);

                Cliente cliente = new Cliente(mail, password, nombre, apellido, 0);
                FormCompradorInicio compradorInicio = new FormCompradorInicio(this, Carniceria, cliente);

                compradorInicio.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Error, revise las credenciales");
            }

        }

        /// <summary>
        /// Activa el formulario Login.
        /// </summary>
        public void MostrarLogin() 
        {
            this.Show();
        }

    }
}