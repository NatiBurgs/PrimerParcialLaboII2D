using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        private int cantidad;
        private Producto producto;


        public Carrito(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public Producto Producto 
        {
            get
            {
                return producto;
            }
        }


    }
}
