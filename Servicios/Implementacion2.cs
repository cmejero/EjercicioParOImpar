using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioParOImpar.Servicios
{
    internal class Implementacion2 : Interfaz2
    {

        public void numeroParOImpar()
        {
            Menuinterfaz mi = new MenuImplementacion();
            int numero;
            numero = mi.pedirNumero();

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }

            else
                Console.WriteLine("El numero es impar");
    }
        }
}
