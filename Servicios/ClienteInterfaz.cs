using NuevoCliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoCliente.Servicios
{
    internal interface ClienteInterfaz
    {
        public void darAltaCliente(List<ClientesDto> listaAntigua);
    }
}
