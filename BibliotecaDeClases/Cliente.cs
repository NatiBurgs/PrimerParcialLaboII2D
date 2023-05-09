using Entidades;

namespace Entidades
{
    public class Cliente : Usuario
    {
        private string nombre;
        private string apellido;
        private int montoDisponible;

     
        public Cliente(string mail, string password, string nombreCliente, string apellidoCliente, int montoDisponibleCliente): base (mail,password)
        {
            nombre = nombreCliente;
            apellido = apellidoCliente;
            montoDisponible = montoDisponibleCliente;

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