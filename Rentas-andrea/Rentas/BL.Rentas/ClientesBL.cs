using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }
        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();

            var cliente1 = new Cliente();
            cliente1.nombre = "Yoselin Bardales Ramirez";
            cliente1.correo = "yoselinBRamires@gmail.com";
            cliente1.direccion = "Col. Buenos Aires";
            cliente1.telefono = 98653254;
            cliente1.Id = 1;
            cliente1.activo = true;
            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.nombre = "Ridel Zaldivar";
            cliente2.correo = "ridelZaldivar@gmail.com";
            cliente2.direccion = "Col. La Esperanza";
            cliente2.telefono = 97849562;
            cliente2.Id = 2;
            cliente2.activo = true;
            ListaClientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.nombre = "Kevin Sosa";
            cliente3.correo = "kevinSosa@gmail.com";
            cliente3.direccion = "Col. Las Delicias";
            cliente3.telefono = 99847562;
            cliente3.Id = 3;
            cliente3.activo = true;
            ListaClientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.nombre = "Ever Fuentes";
            cliente4.correo = "everFuentes@gmail.com";
            cliente4.direccion = "Col. El Faro";
            cliente4.telefono = 92871526;
            cliente4.Id = 4;
            cliente4.activo = true;
            ListaClientes.Add(cliente4);

            var cliente5 = new Cliente();
            cliente5.nombre = "Oslin Ochoa";
            cliente5.correo = "oslinOchoa@gmail.com";
            cliente5.direccion = "Col. Pueblo Nuevo";
            cliente5.telefono = 936954875;
            cliente5.Id = 5;
            cliente5.activo = true;
            ListaClientes.Add(cliente5);
            }
            public bool GuardarCliente (Cliente cliente)
            {
                if (cliente.Id ==0)
                {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
                }

                return true;
            }
        
        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);

        }


        public bool eliminarCliente(int Id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == Id )
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }

            }
            return false;
        }
        
        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }
    }

   


    public class Cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public long telefono { get; set; }
        public string direccion { get; set; }
        public bool activo { get; set; }
    }
}
