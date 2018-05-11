
using System;

namespace ventas
{

	public class Usuarios
	{
		public int Id { get; set; }
		public string NOMBRE { get; set; }
		public string APELLIDO_P { get; set; }
		public string APELLIDO_M { get; set; }
		public string NICKNAME { get; set; }
		public string PASSWORD { get; set; }
		
		
		public Usuarios()
		{
		}

		public Usuarios(int pId, string pNOMBRE, string pAPELLIDO_P,
		                string pAPELLIDO_M, string pNICKNAME, string pPASSWORD){
			this.Id = pId;
			this.NOMBRE = pNOMBRE;
			this.APELLIDO_P = pAPELLIDO_P;
			this.APELLIDO_M = pAPELLIDO_M;
			this.NICKNAME = pNICKNAME;
			this.PASSWORD = pPASSWORD;
		}
	}
}
