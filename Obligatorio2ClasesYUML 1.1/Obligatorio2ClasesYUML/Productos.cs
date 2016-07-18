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

				set{
					if((value.Trim()).Length!=0){codigoDeBarras=value;}//Verifico que haya ingresado al menos una letra
					else{throw new Exception("El codigo de barras debe de contener almenos un digito.");}
				}

			}

			public DateTime FechaDeVencimiento{

				get{return fechaDeVencimiento;}

				set{//Se controla que no este vencido al ingresarlo al sistema.
					if(value>DateTime.Now()){//A verificar si es correcta la sintaxis.
						fechaDeVencimiento=value;
					}else{
						throw new Exception("El producto ya esta vencido, haga el reclamo correspondiente.");
					}
					
				}

			}

			public string Nombre{

				get{return nombre;}

				set{
					if((value.Trim()).Length!=0){
						nombre=value;
					}
					
				}

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

        //Recibe un atributo cualquiera(todo lo creado es object), verifica si es de la clase producto, y luego verifica si tiene el mismo codigo de barras
	//Si tiene el mismo codigo de barras se considera que es el mismo producto y no puede estar dos veces ingresado el mismo producto
			public override bool Equals(object obj){
				bool igual=false;//inicializa en false
				if(obj is Producto){//verifica si lo recibido es de la clase Producto
					if(((Producto)obj).CodigoDeBarras==this.CodigoDeBarras){//Compara la cedula del objeto recibido con la cedula del producto al cual se le hace un punto
						igual=true;//si son iguales devuelve true;
					}
				}
				return igual;
			}

		#endregion

    }

}
