using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        private  List<Vendedor> vendedores;
        private  List<Cliente> clientes;
        private List<Producto> stockList;
        private List<Factura> facturaList;
        public Empresa()
        {
            vendedores = new List<Vendedor>();
            clientes = new List<Cliente>(); 
            stockList = new List<Producto>();
            facturaList = new List<Factura>();
        }

        /// <summary>
        /// Agrega clases del tipo Factura a la lista facturaList de la clase Empresa.
        ///
        /// </summary>
        /// <param Factura="facturaNueva"></param>
        public void AgregarFacturas(Factura facturaNueva) 
        {
            facturaList.Add(facturaNueva);
        }

        /// <summary>
        /// Carga las Facturas de la clase Empresa.
        /// </summary>
        public void CargarFacturas() 
        {
            facturaList.Add(new Factura("Maria Carmen", "Débito", 2500, "Milanesa", 2));
            facturaList.Add(new Factura("Pedro", "Crédito", 10500, "Asado", 5));
            facturaList.Add(new Factura("Natalia", "Efectivo", 12000, "Milanesa", 5));
            facturaList.Add(new Factura("Celeste", "Crédito", 20000, "Asado", 10));
            facturaList.Add(new Factura("Juan", "Débito", 800, "Chorizo", 1));
        }
        /// <summary>
        /// Retorna la lista facturaList de la clase Empresa.
        /// </summary>
        /// <returns>facturaList</returns>
        public List<Factura> MostrarFacturas() 
        {
            return facturaList;
        }

        /// <summary>
        /// Carga la lista de clientes de la clase Empresa.
        /// </summary>
        public void CargarClientes() 
        {
            clientes.Add(new Cliente("Natalia@gmail.com", "123", "Natalia", "Burgos", 10000));
            clientes.Add(new Cliente("Daniel@gmail.com", "456", "Daniel", "Caceres", 5000));
            clientes.Add(new Cliente("Pepe@gmail.com", "1234", "Pepe", "Perez", 10000));
            clientes.Add(new Cliente("Maria@gmail.com", "1234", "Maria", "Gonzales", 10000));
            clientes.Add(new Cliente("Miguel@gmail.com", "1234", "Miguel", "Gimenez", 10000));
            clientes.Add(new Cliente("Abigail@gmail.com", "1234", "Abigail", "Cardozo", 10000));
        }
        /// <summary>
        /// Retorna la lista de clientes de la clase Empresa.
        /// </summary>
        /// <returns>clientesList</returns>
        public List<Cliente> MostrarListaClientes()
        {
            return clientes;
        }

        /// <summary>
        /// Carga los productos a la lista stockList de la clase Empresa.
        /// </summary>
        public  void CargarStock() 
        {
            stockList.Add(new Producto("Matambre", 500, 10));
            stockList.Add(new Producto("Lomo", 800, 10));
            stockList.Add(new Producto("Milanesa", 1000, 15));
            stockList.Add(new Producto("Picada", 1500, 20));
            stockList.Add(new Producto("Cuadril", 800, 10));
            stockList.Add(new Producto("Asado", 2000, 20));
            stockList.Add(new Producto("Vacio", 1000, 15));
        }
        /// <summary>
        /// Retorna la lista de productos de la clase Empresa.
        /// </summary>
        /// <returns>stockList</returns>
        public List<Producto> MostrarStockProductos() 
        {
            return stockList;
        }
        /// <summary>
        /// Carga los vendedores a la lista de vendedores de la clase Empresa.
        /// </summary>
        public void CargarVendedores() 
        {
            vendedores.Add(new Vendedor("Rocio123", "123", "Rocio", "Burgos",stockList));
            vendedores.Add(new Vendedor("Celeste456", "456", "Celeste", "Burgos",stockList));
        }
        /// <summary>
        /// Valida que el mail corresponda a un vendedor de la lista vendedores.
        /// Si corresponde retorna true, en caso contrario false.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>false</returns>
        public  bool ValidarLoginAVendedores(string mail)
        {
            bool valido = false;

            foreach (var usuario in vendedores)
            {
                if (mail == usuario.Mail)
                {
                    valido = true;
                }
            }
            return valido;
        }
        /// <summary>
        /// Valida que el mail corresponda al de un cliente de la lista clientes.
        /// Si corresponde retorna true, en caso contrario false.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>false</returns>
        public  bool ValidarLoginAClientes(string mail)
        {
            bool valido = false;

            foreach (var usuario in clientes)
            {
                if (mail == usuario.Mail)
                {
                    valido = true;
                }
            }
            return valido;
        }
        /// <summary>
        /// Si el nombre ingresado coinde con el nombre de algun producto de la lista retorna true,
        /// de caso contrario false.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>false or true</returns>
        public bool ValidarProducto(string nombre) 
        {
            foreach(var producto in stockList) 
            {
                if (nombre == producto.NombreProducto)
                { 
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Obtiene el nombre del cliente a través del mail ingresado.
        /// Retorna true si coincide, de caso contrario false.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>false or true</returns>
        public  string ObtenerNombreCliente(string mail)
        {
            string nombre = "";

            foreach (var usuario in clientes) 
            {
                if (mail == usuario.Mail)
                {
                    nombre = usuario.Nombre;
                }
            }
            return nombre;
        }
        /// <summary>
        /// Obtiene el nombre del cliente a traves del EnumeradoClientes.
        /// </summary>
        /// <param name="indiceProducto"></param>
        /// <returns>nombreCliente</returns>
        public string ObtenerNombreCliente(int indiceProducto)
        {
            EnumeradoClientes clientes = (EnumeradoClientes)indiceProducto;
            return clientes.ToString();
        }
        /// <summary>
        /// Obtiene el apellido del cliente a través de ingresar su mail.
        /// Si no encuentra devuelde un espacio vacío.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>apellidoCliente</returns>
        public string ObtenerApellidoCliente(string mail)
        {
            string nombre = "";

            foreach (var usuario in clientes)
            {
                if (mail == usuario.Mail)
                {
                    nombre = usuario.Apellido;
                }
            }
            return nombre;
        }

        /// <summary>
        /// Retorna la lista de productos de la clase Empresa.
        /// </summary>
        /// <returns>stockList</returns>
        public List<Producto> MostrarCatalogo() 
        {
            List<Producto> catalogo = new List<Producto>();

            foreach (var item in stockList)
            {
                catalogo.Add(item);
            }
            return catalogo;
        }
        /// <summary>
        /// Retorna el objeto Cliente de la lista clienteList de la clase Empresa, a través del nombre.
        /// </summary>
        /// <param name="nombreCliente"></param>
        /// <returns>Cliente</returns>
        public Cliente ObtenerDatosCliente(string nombreCliente) 
        {
            List<Cliente> listaCliente = MostrarListaClientes();
            Cliente clienteRetorno = new Cliente("Null", "null", "null", "null", 0);
            
            for (int i = 0; i < listaCliente.Count; i++) 
            {
                if (listaCliente[i].Nombre == nombreCliente) 
                {
                    clienteRetorno = listaCliente[i];
                }
            }
            return clienteRetorno;  
        }
        /// <summary>
        /// Busca el producto a través del nombre de éste, en la lista stockLista de la clase Empresa.
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <returns>Producto</returns>
        public Producto ObtenerProducto(string nombreProducto) 
        {
            List<Producto> listaProducto = MostrarStockProductos();
            Producto productoRetorno = new("NULL",0,0);
            foreach (var item in listaProducto) 
            {
                if (nombreProducto == item.NombreProducto) 
                {
                    productoRetorno = item;
                }
            }
            return productoRetorno;
        }
        /// <summary>
        /// Obtiene el nombre de el producto a través de el indice del producto.
        /// </summary>
        /// <param name="indiceProducto"></param>
        /// <returns>string nombre</returns>
        public string ObtenerProductoPorIndice(int indiceProducto)
        {
            List<Producto> listaProductos = MostrarStockProductos();
            string retorno = "Null";
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (indiceProducto == i)
                {
                    return listaProductos[i].NombreProducto;
                }
            }
            return retorno; 
        }

        /// <summary>
        /// Agrega productos al stock.
        /// </summary>
        /// <param name="productoAgregar"></param>
        /// <param name="cantidadAStockear"></param>
        public  void AgregarProductosEnStock(string productoAgregar, int cantidadAStockear)
        {
            Producto productoAStockear = ObtenerProducto(productoAgregar);
            productoAStockear.CantidadDisponible += cantidadAStockear;
        }
        /// <summary>
        /// Agrega un objeto nuevo del tipo Producto.
        /// </summary>
        /// <param name="productoNuevo"></param>
        public void AgregarProductoNuevo(Producto productoNuevo)
        {
            stockList.Add(productoNuevo);
        }
        /// <summary>
        /// Modifica la cantidad del producto.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidadAModificar"></param>
        public void ReducirStock(string producto, int cantidadAModificar) 
        {
            Producto productoAModificar = ObtenerProducto(producto);
            productoAModificar.CantidadDisponible -= cantidadAModificar;
        }
        /// <summary>
        /// Retorna true si la cantidad del producto es mayor a cero.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>true or false</returns>
        public bool ConsultarStock(string producto)
        { 
            bool retorno = false;
            Producto productoRetorno = ObtenerProducto(producto);
            if (productoRetorno.CantidadDisponible > 0) 
            {
                retorno =  true;
            }
            return retorno;
        }
        /// <summary>
        /// Realiza el cambio de precio del producto ingresado.
        /// </summary>
        /// <param name="productoNombre"></param>
        /// <param name="precioNuevo"></param>
        public void CambiarPrecioProducto(string productoNombre, int precioNuevo) 
        {
            ObtenerProducto(productoNombre).PrecioKilo = precioNuevo;
        }



        
    }

}
