using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioParOImpar.Servicios
{
    internal class Implementacion2 : Interfaz2
    {

        public void numeroParOImpar(int numerUsuario)
        {
            Menuinterfaz mi = new MenuImplementacion();

           

            if (numerUsuario % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }

            else
                Console.WriteLine("El numero es impar");
    }
        }
}
