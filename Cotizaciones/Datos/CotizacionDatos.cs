using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Cotizaciones.Modelos;

namespace Cotizaciones.Datos
{
    class CotizacionDatos
    {
        public int Agregar(Cotizacion cotizacion)
        {
            int id_cotizacion = 0;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_cliente = cotizacion.Id_cliente;
                string titulo = cotizacion.Titulo;
                string descripcion = cotizacion.Descripcion;
                string moneda = cotizacion.Moneda;
                string fecha = cotizacion.Fecha;

                var query = new SQLiteCommand("INSERT INTO cotizaciones(id_cliente, titulo, descripcion, moneda, fecha) VALUES (@p0, @p1, @p2, @p3, @p4); SELECT last_insert_rowid();", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cliente);
                query.Parameters.AddWithValue("@p1", titulo);
                query.Parameters.AddWithValue("@p2", descripcion);
                query.Parameters.AddWithValue("@p3", moneda);
                query.Parameters.AddWithValue("@p4", fecha);

                id_cotizacion = Convert.ToInt32(query.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return id_cotizacion;
        }

        public Boolean Editar(Cotizacion cotizacion)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_cotizacion = cotizacion.Id_cotizacion;
                int id_cliente = cotizacion.Id_cliente;
                string titulo = cotizacion.Titulo;
                string descripcion = cotizacion.Descripcion;
                string moneda = cotizacion.Moneda;
                string fecha = cotizacion.Fecha;

                var query = new SQLiteCommand("UPDATE cotizaciones SET id_cliente = @p0, titulo = @p1, descripcion = @p2, moneda = @p3, fecha = @p4 WHERE id_cliente = @p5", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cliente);
                query.Parameters.AddWithValue("@p1", titulo);
                query.Parameters.AddWithValue("@p2", descripcion);
                query.Parameters.AddWithValue("@p3", moneda);
                query.Parameters.AddWithValue("@p4", fecha);
                query.Parameters.AddWithValue("@p5", id_cotizacion);

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

        public Boolean Borrar(int id_cotizacion)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM cotizaciones where id_cotizacion = @p0", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cotizacion);

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

        public ArrayList cargarCotizaciones()
        {
            ArrayList listaCotizaciones = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "SELECT co.id_cotizacion, co.id_cliente, cl.nombre, co.titulo, co.descripcion, co.moneda, co.fecha FROM cotizaciones co, clientes cl WHERE co.id_cliente = cl.id_cliente";
            var reader = conexion.comando.ExecuteReader();
            while (reader.Read())
            {
                Cotizacion cotizacion = new Cotizacion();
                if (!reader.IsDBNull(0))
                {
                    cotizacion.Id_cotizacion = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    cotizacion.Id_cliente = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    cotizacion.Nombre_cliente = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    cotizacion.Titulo = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    cotizacion.Descripcion = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    cotizacion.Moneda = reader.GetString(5);
                }
                if (!reader.IsDBNull(6))
                {
                    cotizacion.Fecha = reader.GetString(6);
                }
                listaCotizaciones.Add(cotizacion);
            }
            reader.Close();
            conexion.cerrar();
            return listaCotizaciones;
        }

        public Cotizacion cargarCotizacion(int id_cotizacion)
        {
            Cotizacion cotizacion = new Cotizacion();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT co.id_cotizacion, co.id_cliente, cl.nombre, co.titulo, co.descripcion, co.moneda, co.fecha FROM cotizaciones co, clientes cl WHERE co.id_cliente = cl.id_cliente AND co.id_cotizacion = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_cotizacion);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    cotizacion.Id_cotizacion = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    cotizacion.Id_cliente = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    cotizacion.Nombre_cliente = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    cotizacion.Titulo = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    cotizacion.Descripcion = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    cotizacion.Moneda = reader.GetString(5);
                }
                if (!reader.IsDBNull(6))
                {
                    cotizacion.Fecha = reader.GetString(6);
                }
            }
            reader.Close();
            conexion.cerrar();
            return cotizacion;
        }

        public bool comprobar_existencia_cotizacion_crear(string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM cotizaciones WHERE titulo = @p0", conexion.conexion);
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

        public bool comprobar_existencia_cotizacion_editar(int id_cotizacion, string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM cotizaciones WHERE titulo = @p0 AND id_cotizacion != @p1", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            query.Parameters.AddWithValue("@p1", id_cotizacion);
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
