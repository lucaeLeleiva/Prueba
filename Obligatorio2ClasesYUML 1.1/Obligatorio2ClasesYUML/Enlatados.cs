using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio2ClasesYUML
{
    class Enlatados:Productos
    {
		#region Atributos
			bool abreFacil;
		#endregion
		#region Propiedades
			public bool AbreFacil{
				get{return abreFacil;}
				set{abreFacil=value;}
			}
		#endregion
		#region Constructores
			public Enlatados(bool abreFacil,string codigoDeBarras,DateTime fechaDeVencimiento,string nombre,double precio):base(codigoDeBarras, fechaDeVencimiento, nombre, precio){
			this.AbreFacil=abreFacil;
		}
		#endregion
		#region Operaciones
			public override string ToString(){
				string frase="";
				if(abreFacil){
					frase=base.ToString()+" y tiene abre facil.";
				}else if(!abreFacil){
                    frase = base.ToString() + " y no tiene abre facil.";
				}
				return frase;
			}
		#endregion
    }
}
