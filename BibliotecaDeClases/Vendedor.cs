
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Usuario
    {
        private string nombre;
        private string apellido;
        private List<Producto> catalogo;

        public Vendedor(string mail, string password, string nombre, string apellido, List<Producto> stockEmpresa):base(mail,password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            catalogo = stockEmpresa;
        }


    }
}
