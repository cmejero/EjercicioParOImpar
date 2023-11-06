using edu.ejercicioParOImpar.Servicios;

namespace edu.ejercicioParOImpar.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menuinterfaz mi = new MenuImplementacion();
           
            Interfaz2 I2 = new Implementacion2();
            int numerUsuario = mi.pedirNumero();
            I2.numeroParOImpar(numerUsuario);
            
        }          
                    
    }
}