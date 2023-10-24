using edu.ejercicioParOImpar.Servicios;

namespace edu.ejercicioParOImpar.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menuinterfaz mi = new MenuImplementacion();
            Interfaz2 I2 = new Implementacion2();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.pedirNumero();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("se ha ejecutado la opción 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("se ha ejecutado la opción 1");
                        I2.numeroParOImpar();
                        break;

                    default:
                        Console.WriteLine("la opcion no corresponde con ninguna");
                        break;


                }
            }
        }          
                    
    }
}