
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {

        /// <summary>
        /// Retorna true si el texto es diferente de null y la cantidad de letras es mayor a cero.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>true or false</returns>
        public static bool ValidarTexto(string texto) 
        {
            bool retorno = true;
            if (texto == null) 
            {
                retorno = false;
            }
            else if (texto.Length == 0) 
            {
                retorno = false; 
            }
            return true;
        }
        /// <summary>
        /// Retorna true si el numero es mayor al valor cero y false de caso contrario.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>true or false</returns>
        public static bool ValidarNumeroMayorACero(string texto) 
        {
            int texto2;
            
            if(texto.Length > 0)
            {
                texto2 = int.Parse(texto);
                if (texto2 > 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
