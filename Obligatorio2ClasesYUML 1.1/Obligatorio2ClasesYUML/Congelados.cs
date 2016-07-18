using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio2ClasesYUML
{
    class Congelados:Productos
    {
		#region Atributos
			int pesoEnGramos;
		#endregion
		#region Propiedades
			public int PesoEnGramos{
				get{return pesoEnGramos;}
				set{pesoEnGramos=value;}
			}
		#endregion
		#region Constructores
			public Congelados(int pesoEnGramos,string codigoDeBarras,DateTime fechaDeVencimiento,string nombre,double precio):base(codigoDeBarras, fechaDeVencimiento, nombre, precio){
			this.PesoEnGramos=pesoEnGramos;
		}
		#endregion
		#region Operaciones
			public override string  ToString(){
				string frase;
                frase=base.ToString()+" y pesa "+pesoEnGramos+"g";
                return frase;
            }
				
			
		#endregion
    }
}
