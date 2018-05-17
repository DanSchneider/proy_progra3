
using System;

namespace ventas.Clases.SqlClientes
{

	public class Clientes
	{
		public int Id { get; set; }
		public string NOMBRE { get; set; }
		public double TELEFONO { get; set; }

		
		
		public Clientes()
		{
		}
		
		public Clientes(int clId, string clNOMBRE, double clTELEFONO){
			this.Id = clId;
			this.NOMBRE = clNOMBRE;
			this.TELEFONO = clTELEFONO;
			
	}
}
}