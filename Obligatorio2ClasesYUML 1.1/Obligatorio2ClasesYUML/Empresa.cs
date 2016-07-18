using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio2
{
    class Empresa
    {
        #region Atributos

        List<Cliente> listaClientes;
        List<Producto> listaProductos;
        //List<Venta> listaVentas; Esta linea esta comentada porque no tengo la clase "venta"

        #endregion

        #region Operaciones

        public Cliente BuscarCliente(string cedula) //Operacion para buscar un cliente por la cedula en la lista de clientes 
        {
            Cliente resp = null;
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Cedula == cedula)
                { resp = cliente; }
            }
            return resp; 
        }

        #endregion
    }
}
