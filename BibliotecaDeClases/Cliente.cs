using Entidades;
using System.Reflection.Metadata.Ecma335;

namespace Entidades
{
    public class Cliente : Usuario
    {
        private string nombre;
        private string apellido;
        private int montoDisponible;
        private List<Carrito> carritoList;

     
        public Cliente(string mail, string password, string nombreCliente, string apellidoCliente, int montoDisponibleCliente): base (mail,password)
        {
            nombre = nombreCliente;
            apellido = apellidoCliente;
            montoDisponible = montoDisponibleCliente;
            carritoList = new List<Carrito>();
        }

        public List<Carrito> RetornarListaCarrito() 
        {
            return carritoList;
        }

        public void AgregarACarrito(Producto productoAgregar, int cantidadAgregar) 
        {
           bool flagExiste = false; 

           
           foreach(Carrito unidad in carritoList) 
           {
                if (productoAgregar.NombreProducto == unidad.Producto.NombreProducto)
                {
                    flagExiste = true;
                    unidad.Cantidad += cantidadAgregar;
                }
           }

            if (!flagExiste)
            {
                carritoList.Add(new Carrito(cantidadAgregar, productoAgregar));
            }
        }

        public void QuitarDeCarrito(Carrito carrito) 
        {
            carritoList.Remove(carrito);
        }

        /// <summary>
        /// Busca el producto a través del nombre de éste, en la lista stockLista de la clase Empresa.
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <returns>Producto</returns>
        public Carrito ObtenerCarrito(string nombreCarrito)
        {
            List<Carrito> listaCarrito = RetornarListaCarrito();
            Producto productoRetorno = new("NULL", 0, 0);
            Carrito carritoRetorno = new(0, productoRetorno);
            foreach (var item in listaCarrito)
            {
                if (nombreCarrito == item.Producto.NombreProducto)
                {
                    carritoRetorno = item;
                }
            }
            return carritoRetorno;
        }
        /// <summary>
        /// Obtiene el nombre de el producto a través de el indice del producto.
        /// </summary>
        /// <param name="indiceProducto"></param>
        /// <returns>string nombre</returns>
        public string ObtenerCarritoPorIndice(int indiceProducto)
        {
            List<Carrito> listaCarrito = RetornarListaCarrito();
            string retorno = "Null";
            for (int i = 0; i < listaCarrito.Count; i++)
            {
                if (indiceProducto == i)
                {
                    return listaCarrito[i].Producto.NombreProducto;
                }
            }
            return retorno;
        }


        /// <summary>
        /// Realiza el calculo de precioFinal.
        /// </summary>
        /// <param name="precioPorKg"></param>
        /// <param name="cantidadAComprar"></param>
        /// <returns>inr precioFinal</returns>
        public int ComprarProducto(int precioPorKg, int cantidadAComprar) 
        {
            int precioFinal = cantidadAComprar * precioPorKg;

            return precioFinal;
        }
        
        /// <summary>
        /// Realiza el calculo de precioFinal con interés.
        /// </summary>
        /// <param name="precioPorKg"></param>
        /// <param name="cantidadAComprar"></param>
        /// <param name="interes"></param>
        /// <returns>int precioFinal</returns>
        public int ComprarProducto(int precioPorKg, int cantidadAComprar, int interes)
        {
            int precio = cantidadAComprar * precioPorKg;
            int precioFinal = precio + ((precio * interes) / 100);

            return precioFinal;
        }

        public int ComprarProducto(int montoSubTotal, string metodoDePago) 
        {
            int retorno;
            if (metodoDePago == "Debito")
            {
                retorno = montoSubTotal;
            }
            else if (metodoDePago == "Credito")
            {
                retorno = montoSubTotal + ((montoSubTotal * 5)/100); 
            }
            else 
            {
                retorno = montoSubTotal;
            }

            return retorno;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int MontoDisponible
        {
            get
            {
                return montoDisponible;
            }
            set
            {
                montoDisponible = value;
            }
        }
    }

}