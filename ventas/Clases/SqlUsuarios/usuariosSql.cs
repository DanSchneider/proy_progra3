using System;
using MySql.Data.MySqlClient;

namespace ventas
{

	public class UsuariosSql
	{
		public static int Agregar(Usuarios pUsuarios)
		{

			int retorno = 0;

			MySqlCommand comando = new MySqlCommand(string.Format(
				                              "Insert into usuarios (NOMBRE, APELLIDO_P, APELLIDO_M, NICKNAME, PASSWORD) values ('{0}','{1}','{2}', '{3}','{4}')",
				                              pUsuarios.NOMBRE, pUsuarios.APELLIDO_P, pUsuarios.APELLIDO_M, pUsuarios.NICKNAME, pUsuarios.PASSWORD),
				                              conexion.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return  retorno;
		}
	}
}
