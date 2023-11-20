using NuevoCliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoCliente.Servicios
{
    internal class ClienteImplementacion:ClienteInterfaz
    {
        public void darAltaCliente(List<ClientesDto> listaAntigua)
        {
            ClientesDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
        }

        private ClientesDto crearNuevoCliente()
        {
            ClientesDto nuevoCliente= new ClientesDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el numero de telefono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            return nuevoCliente;
        }
    }
}
