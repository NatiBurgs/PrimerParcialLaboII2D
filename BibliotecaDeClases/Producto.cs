using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombreProducto;
        int precioKilo;
        int cantidadDisponible;

        public Producto(string nombreProductoNuevo, int precioKiloNuevo, int cantidadDisponibleNuevo)
        {
            nombreProducto = nombreProductoNuevo;
            precioKilo = precioKiloNuevo;
            cantidadDisponible = cantidadDisponibleNuevo;
        }
        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }
            set
            {
                nombreProducto = value;
            }
        }

        public int PrecioKilo
        {
            get
            {
                return precioKilo;
            }
            set
            {
                precioKilo = value;
            }
        }

        public int CantidadDisponible
        {
            get
            {
                return cantidadDisponible;
            }
            set
            {
                cantidadDisponible = value;
            }
        }

 
    }
}
