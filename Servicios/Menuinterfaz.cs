using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioParOImpar.Servicios
{/// <summary>
/// Interfaz que declara el método de pedir número
/// <author> cmr-0611 </author>
/// </summary>
    internal interface Menuinterfaz
    {

       /// <summary>
       /// Solicitara un numero entero al usuario 
       /// </summary>
       /// <returns>un numero entero</returns>
        public int pedirNumero();
    }
}
