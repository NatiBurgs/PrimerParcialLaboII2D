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
            AutoCompleteTextBox();
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

            EliminarErrorProvider();
            if (ValidarCamposTexto())
            {

                if (Carniceria.ValidarLoginAVendedores(mail,password) == true)
                {
                    FormVendedor vendedor = new FormVendedor(this, Carniceria);
                    vendedor.Show();
                    this.Hide();

                }
                else if (Carniceria.ValidarLoginAClientes(mail, password) == true)
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

        }

        /// <summary>
        /// Método para autocompletar los textBox del formulario.
        /// </summary>
        private void AutoCompleteTextBox()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            foreach (var v in Carniceria.MostrarListaClientes())
            {
                lista.Add(v.Mail);

            }

            foreach (var i in Carniceria.MostrarListaVendedores())
            {
                lista.Add(i.Mail);
            }

            textBox1.AutoCompleteCustomSource = lista;

        }

        /// <summary>
        /// Activa el formulario Login.
        /// </summary>
        public void MostrarLogin()
        {
            this.Show();
        }

        /// <summary>
        /// Comprueba la validación de los compos.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidarCamposTexto()
        {
            bool retorno = true;
            if (textBox1.Text == "")
            {
                retorno = false;
                errorProvider1.SetError(textBox1, "Ingresar Mail");
            }
            if (textBox2.Text == "")
            {
                retorno = false;
                errorProvider1.SetError(textBox2, "Ingresar password");
            }

            return retorno;

        }

        /// <summary>
        /// Elimina el errorProvider.
        /// </summary>
        private void EliminarErrorProvider()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
        }
    }
}