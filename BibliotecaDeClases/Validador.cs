
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
        /// Retorna true si el numero es mayor al valor cero y false de caso contrario.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>true or false</returns>

        private static bool SoloLetras(string letra)
        {
            foreach (Char ch in letra)
            {
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
