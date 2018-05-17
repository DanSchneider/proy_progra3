using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ventas.Clases.SqlClientes
{

	public class ClientesSql
	{
		public static int Agregar(Clientes clClientes)
		{

			int retorno = 0;

			MySqlCommand comando = new MySqlCommand(string.Format(
				"Insert into clientes (NOMBRE, TELEFONO) values ('{0}','{1}')",
				clClientes.NOMBRE,clClientes.TELEFONO),
			                                        conexion.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return  retorno;
		}
		
		public static List<Clientes>  mostrarClientes(){
			List<Clientes> _lista2 = new List<Clientes>();
			
			MySqlConnection con = conexion.ObtenerConexion();
			
			MySqlCommand _comando = new MySqlCommand(String.Format("select * from clientes;"), con);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				Clientes clClientes = new Clientes();
				
				clClientes.Id = _reader.GetInt32(0);
				clClientes.NOMBRE = _reader.GetString(1);
				clClientes.TELEFONO = _reader.GetDouble(2);
				
				_lista2.Add(clClientes);
			}
			
			return _lista2;
			
		}
	}
}
