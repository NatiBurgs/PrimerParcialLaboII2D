using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        string nombreComprador;
        string metodoDePago;
        Random rand;
        int montoTotal;
        string nombreProducto;
        int cantidadProducto;


        public Factura(string nombreComprador, string metodoDePago, int montoTotal, string nombreProducto, int cantidadProducto) 
        {
            this.nombreComprador = nombreComprador;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.montoTotal = montoTotal;
            this.metodoDePago = metodoDePago;
            rand = new Random();
        }

   
        public string NombreDeComprador
        {
            get
            {
                return nombreComprador;
            }
            set
            {
                nombreComprador = value;
            }
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

        public int CantidadProducto
        {
            get
            {
                return cantidadProducto;
            }
            set
            {
                cantidadProducto = value;
            }
        }

        public int MontoTotal
        {
            get
            {
                return montoTotal;
            }
            set
            {
                montoTotal = value;
            }
        }

        public string MetodoDePago
        {
            get
            {
                return metodoDePago;
            }
            set
            {
                metodoDePago = value;
            }
        }
 

        public int Rand
        {
            get
            {
                return rand.Next(100,1000);
            }

        }


    }
}
