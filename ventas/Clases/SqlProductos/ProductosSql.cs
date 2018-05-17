
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ventas
{

	public class ProductosSql
	{
		
		
		
		public static int Agregar(Productos prProductos)
		{

			int retorno = 0;

			MySqlCommand comando = new MySqlCommand(string.Format(
				"Insert into productos (NOMBRE, EXISTENCIA, PRECIO_NETO, PRECIO_VENTA) values ('{0}','{1}','{2}', '{3}')",
				prProductos.NOMBRE,prProductos.EXISTENCIA,prProductos.PRECIO_N,prProductos.PRECIO_V),
			                                        conexion.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return  retorno;
		}
		
		public static List<Productos> Buscar(int prId)
		{
			List<Productos> _lista = new List<Productos>();
			
			MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT * FROM productos  where ID_PRODUCTO='{0}'",prId), conexion.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Productos prProductos = new Productos();
				
				prProductos.Id = _reader.GetInt32(0);
				prProductos.NOMBRE = _reader.GetString(1);
				prProductos.EXISTENCIA = _reader.GetInt32(2);
				prProductos.PRECIO_N = _reader.GetInt32(3);
				prProductos.PRECIO_V = _reader.GetInt32(4);
				

				_lista.Add(prProductos);
			}
			
			return _lista;
		}
		
		public static List<Productos>  mostrarProductos(){
			List<Productos> _lista2 = new List<Productos>();
			
			MySqlConnection con = conexion.ObtenerConexion();
			
			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM productos"), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Productos prProductos = new Productos();
				
				prProductos.Id = _reader.GetInt32(0);
				prProductos.NOMBRE = _reader.GetString(1);
				prProductos.EXISTENCIA = _reader.GetInt32(2);
				prProductos.PRECIO_N = _reader.GetInt32(3);
				prProductos.PRECIO_V = _reader.GetInt32(4);

				_lista2.Add(prProductos);
			}
			
			return _lista2;
			
		}
		
		public static Productos ObtenerProductos(int pId)
		{
			Productos prProductos = new Productos();
			MySqlConnection con = conexion.ObtenerConexion();

			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM productos  where ID_PRODUCTO={0}", pId), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				prProductos.Id = _reader.GetInt32(0);
				prProductos.NOMBRE = _reader.GetString(1);
				prProductos.EXISTENCIA = _reader.GetInt32(2);
				prProductos.PRECIO_N = _reader.GetInt32(3);
				prProductos.PRECIO_V = _reader.GetInt32(4);
				
			}

			con.Close();
			return prProductos;
			
		}
		
		public static int Actualizar(Productos prProductos)
		{
			int retorno = 0;
			
			MySqlConnection con = conexion.ObtenerConexion();
			
			MySqlCommand comando = new MySqlCommand(string.Format("Update productos set NOMBRE='"+prProductos.NOMBRE+"', EXISTENCIA='"+
			                                                      prProductos.EXISTENCIA+"', PRECIO_NETO='"+prProductos.PRECIO_N+
			                                                      "', PRECIO_VENTA='"+prProductos.PRECIO_V+"' where ID_PRODUCTO='"+prProductos.Id+"'"), con);
			
			

			retorno = comando.ExecuteNonQuery();
			con.Close();
			
			return retorno;


		}
		
		public static int Eliminar(int pId)
		{
			int retorno = 0;
			
			MySqlConnection con = conexion.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("Delete From productos where ID_PRODUCTO={0}", pId), con);

			retorno = comando.ExecuteNonQuery();
			con.Close();

			return retorno;

		}
	}
}
