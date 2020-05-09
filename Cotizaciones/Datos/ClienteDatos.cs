using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Cotizaciones.Modelos;

namespace Cotizaciones.Datos
{
    class ClienteDatos
    {
        public Boolean Agregar(Cliente cliente)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string nombre = cliente.Nombre;
                string email = cliente.Email;

                var query = new SQLiteCommand("INSERT INTO clientes(nombre, email) VALUES (@p0, @p1)", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", email);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public Boolean Editar(Cliente cliente)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_cliente = cliente.Id_cliente;
                string nombre = cliente.Nombre;
                string email = cliente.Email;

                var query = new SQLiteCommand("UPDATE clientes SET nombre = @p0, email = @p1 WHERE id_cliente = @p2", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", email);
                query.Parameters.AddWithValue("@p2", id_cliente);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public Boolean Borrar(int id_cliente)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM clientes where id_cliente = @p0", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cliente);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public ArrayList cargarClientes()
        {
            ArrayList listaClientes = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "SELECT id_cliente, nombre, email FROM clientes";
            var reader = conexion.comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                if (!reader.IsDBNull(0))
                {
                    cliente.Id_cliente = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    cliente.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    cliente.Email = reader.GetString(2);
                }
                listaClientes.Add(cliente);
            }
            reader.Close();
            conexion.cerrar();
            return listaClientes;
        }

        public Cliente cargarCliente(int id_cliente)
        {
            Cliente cliente = new Cliente();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT id_cliente, nombre, email FROM clientes WHERE id_cliente = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_cliente);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    cliente.Id_cliente = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    cliente.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    cliente.Email = reader.GetString(2);
                }
            }
            reader.Close();
            conexion.cerrar();
            return cliente;
        }

        public bool comprobar_existencia_cliente_crear(string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM clientes WHERE nombre = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            var result = query.ExecuteScalar().ToString();
            int count = Convert.ToInt32(result);
            if (count >= 1)
            {
                respuesta = true;
            }
            conexion.cerrar();

            return respuesta;
        }

        public bool comprobar_existencia_cliente_editar(int id_cliente, string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM clientes WHERE nombre = @p0 AND id_cliente != @p1", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            query.Parameters.AddWithValue("@p1", id_cliente);
            var result = query.ExecuteScalar().ToString();
            int count = Convert.ToInt32(result);
            if (count >= 1)
            {
                respuesta = true;
            }
            conexion.cerrar();

            return respuesta;
        }
    }
}
