using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ventas.Clases.SqlVentas
{

	public class SqlVentas
	{
		public static int Agregar(Ventas clVentas)
		{

			int retorno = 0;

			MySqlCommand comando = new MySqlCommand(string.Format(
				"Insert into ventas (USUARIO, CLIENTE, TOTAL_VENTA) values ('{0}','{1}','{2}')",
				clVentas.USUARIO,clVentas.CLIENTE,clVentas.TOTAL_VENTA),
			                                        conexion.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return  retorno;
		}
		
		public static List<Ventas>  mostrarCuenta(){
			List<Ventas> _lista2 = new List<Ventas>();
			
			MySqlConnection con = conexion.ObtenerConexion();
			
			MySqlCommand _comando = new MySqlCommand(String.Format("select ID_VENTA, CLIENTE,TOTAL_VENTA from ventas;"), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Ventas clVentas = new Ventas();
				
				clVentas.Id = _reader.GetInt32(0);
				clVentas.CLIENTE = _reader.GetString(1);
				clVentas.TOTAL_VENTA = _reader.GetDouble(2);
				
				_lista2.Add(clVentas);
			}
			
			return _lista2;
			
		}
	}
}
