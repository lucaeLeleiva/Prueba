using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;


namespace Obligatorio2ClasesYUML
{

    class Productos
    {

		#region Atributos

			string codigoDeBarras;

			DateTime fechaDeVencimiento;

			string nombre;

			double precio;

		#endregion

		#region Propiedades

			public string CodigoDeBarras{

				get{return codigoDeBarras;}

				set{codigoDeBarras=value;}

			}

			public DateTime FechaDeVencimiento{

				get{return fechaDeVencimiento;}

				set{fechaDeVencimiento=value;}

			}

			public string Nombre{

				get{return nombre;}

				set{nombre=value;}

			}

			public double Precio{
				get{ return precio;}
            			set{
                			if (value > 0){precio = value;}
             				else{throw new Exception("El valor del precio debe ser mayor a cero.");}
            			}
        		}
		#endregion

		#region Constructores

			public Productos(string codigoDeBarras,DateTime fechaDeVencimiento,string nombre,double precio){

				this.CodigoDeBarras=codigoDeBarras;

				this.FechaDeVencimiento=fechaDeVencimiento;

				this.Nombre=nombre;

				this.Precio=precio;

			}

		#endregion

		#region Operaciones

			public override string ToString(){

				string frase;

				frase=String.Format("Este producto es {0} tiene el codigo de barras {1} la fecha de vencimiento {2} y un precio unitario de {3} ", nombre, codigoDeBarras, fechaDeVencimiento, precio);

				return frase;

			}

        //De momento voy a llamar Igual hasta consultar con el profesor como sobre escribir equals

			public bool Igual(Productos producto){

				bool igual=false;

				igual=this.CodigoDeBarras==producto.CodigoDeBarras;

				return igual;

			}

		#endregion

    }

}
