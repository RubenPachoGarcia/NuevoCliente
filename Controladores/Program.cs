using NuevoCliente.Dtos;
using NuevoCliente.Servicios;

namespace NuevoCliente
{
    class Program
    {
        public static void Main(string[] args)
        {
            List <ClientesDto> listaClientes = new List <ClientesDto> ();

            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarMensajeBienvenida();
            ClienteInterfaz ci = new ClienteImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                        ci.darAltaCliente(listaClientes);
                        //Pruebas
                        /*foreach (ClientesDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }*/
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }

        }
    }
}