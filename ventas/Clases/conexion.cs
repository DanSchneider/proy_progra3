using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ventas
{

	public static class conexion
	{
		 public static MySqlConnection ObtenerConexion()
       {
		 		// cambiar por el usuario y contraseña de la db que se tenga.
		 		MySqlConnection conectar = new MySqlConnection(
		 			"server=127.0.0.1; database=p_venta2; Uid=root; pwd=newborn;");

           		conectar.Open();
           		return conectar;
           		

       }

	}
}
