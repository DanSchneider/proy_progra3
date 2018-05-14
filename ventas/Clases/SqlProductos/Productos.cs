
using System;

namespace ventas
{

	public class Productos
	{
		public int Id { get; set; }
		public string NOMBRE { get; set; }
		public int EXISTENCIA { get; set; }
		public int PRECIO_N { get; set; }
		public int PRECIO_V { get; set; }
		
		
		public Productos(){}
		
		public Productos(int prId, string prNOMBRE, int prEXISTENCIA,
		                int prPRECIO_N, int prPRECIO_V){
			this.Id = prId;
			this.NOMBRE = prNOMBRE;
			this.EXISTENCIA = prEXISTENCIA;
			this.PRECIO_N = prPRECIO_N;
			this.PRECIO_V = prPRECIO_V;
			
		
	}
		
	}
}
