using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioParOImpar.Servicios
{
    internal class MenuImplementacion : Menuinterfaz
    {
        public int pedirNumero()
        {
            int numero;
            Console.WriteLine("Introduzca un número");
            numero = Convert.ToInt32(Console.ReadLine());
           

            return numero;
        }

       

            
        
            

        
    }
}
