using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio2
{
    class Cliente
    {
        #region Atributos

        string cedula;
        double descuento;
        string direccion;
        string telefono;

        #endregion

        #region Propiedades

        public string Cedula//Aca tengo que controlar que sea unica en el sistema?????
        {
            set //Controlo entre 5 y 7, para que solo sean validos valores de 6 y 7 digitos.
            {
                if (value.Length > 5 && value.Length < 8)
                { cedula = value; }
                else
                { throw new Exception("La cedula debe de tener entre 6 y 7 digitos."); }
            }
            get
            { return cedula; }
        }

        public double Descuento
        {
            set
            {
                if (value >= 0 && value < 100)
                { descuento = value; }
                else
                { throw new Exception("El descuento debe ser entre 0 y 99."); }
            }
            get
            { return descuento; }
        }

        public string Direccion
        {
            set
            {
                if (value.Length != 0)//Controlo que al menos escriba algo.
                { direccion = value; }
                else
                { throw new Exception("Por favor escriba una direccion."); }
            }
            get
            { return direccion.ToUpper(); }
        }

        public string Telefono
        {
            set
            {
                if (value.Length > 7 && value.Length < 10)//Controlo que al menos tenga 8 digitos (fijo) y maximo 9 (celular)
                { telefono = value; }
                else
                { throw new Exception("El telefono debe tener ocho digtos en caso de ser fijo o nueve en caso de ser movil."); }
            }
            get
            { return telefono; }
        }
        #endregion

        #region Constructores

        public Cliente(string pCedula, double pDescuento, string pDireccion, string pTelefono)
        {
            Cedula = pCedula;
            Descuento = pDescuento;
            Direccion = pDireccion;
            Telefono = pTelefono;
        }

        #endregion

        #region Operaciones

        public override string ToString()
        {
            string resp = "Datos del cliente:\nCedula: " + cedula + "\nDescuento: " + descuento;
                resp += "\nDireccion: " + direccion + "\nTelefono: " + telefono;
            return resp;
        }

        #endregion

    }
}
