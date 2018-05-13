using System;
using System.Collections.Generic;
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
		
		public static List<Usuarios> Buscar(string pNOMBRE, string pAPELLIDO_P)
		{
			List<Usuarios> _lista = new List<Usuarios>();
			
			MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT ID_USUARIO, NOMBRE, APELLIDO_P, APELLIDO_M, NICKNAME, PASSWORD FROM usuarios  where NOMBRE ='{0}' or APELLIDO_P='{1}'", pNOMBRE,pAPELLIDO_P), conexion.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Usuarios pUsuarios = new Usuarios();
				
				pUsuarios.Id = _reader.GetInt32(0);
				pUsuarios.NOMBRE = _reader.GetString(1);
				pUsuarios.APELLIDO_P = _reader.GetString(2);
				pUsuarios.APELLIDO_M = _reader.GetString(3);
				pUsuarios.NICKNAME = _reader.GetString(4);
				pUsuarios.PASSWORD = _reader.GetString(5);

				_lista.Add(pUsuarios);
			}
			
			return _lista;
		}
		
		public static List<Usuarios>  mostrarUsuarios(){
			List<Usuarios> _lista2 = new List<Usuarios>();
			
			MySqlConnection con = conexion.ObtenerConexion();
			
			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM usuarios"), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Usuarios pUsuarios = new Usuarios();
				
				pUsuarios.Id = _reader.GetInt32(0);
				pUsuarios.NOMBRE = _reader.GetString(1);
				pUsuarios.APELLIDO_P = _reader.GetString(2);
				pUsuarios.APELLIDO_M = _reader.GetString(3);
				pUsuarios.NICKNAME = _reader.GetString(4);
				pUsuarios.PASSWORD = _reader.GetString(5);

				_lista2.Add(pUsuarios);
			}
			
			return _lista2;
			
		}
		
		public static Usuarios ObtenerUsuarios(int pId)
		{
			Usuarios pUsuarios = new Usuarios();
			MySqlConnection con = conexion.ObtenerConexion();

			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ID_USUARIO, NOMBRE, APELLIDO_P, APELLIDO_M, NICKNAME, PASSWORD FROM usuarios  where ID_USUARIO={0}", pId), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				pUsuarios.Id = _reader.GetInt32(0);
				pUsuarios.NOMBRE = _reader.GetString(1);
				pUsuarios.APELLIDO_P = _reader.GetString(2);
				pUsuarios.APELLIDO_M = _reader.GetString(3);
				pUsuarios.NICKNAME = _reader.GetString(4);
				pUsuarios.PASSWORD = _reader.GetString(5);
				
			}

			con.Close();
			return pUsuarios;
			
		}
	}
}
