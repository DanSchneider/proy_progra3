
using System;

namespace ventas.Clases.SqlVentas
{

	public class Ventas
	{
		public int Id { get; set; }
		public string USUARIO { get; set; }
		public string CLIENTE { get; set; }
		public double TOTAL_VENTA { get; set; }
		
		
		public Ventas()
		{
		}
		
		public Ventas(int clId, string clUSUARIO, string clCLIENTE, double clTOTALVENTA){
			this.Id = clId;
			this.USUARIO = clUSUARIO;
			this.CLIENTE = clCLIENTE;
			this.TOTAL_VENTA = clTOTALVENTA;

		}
	}
}