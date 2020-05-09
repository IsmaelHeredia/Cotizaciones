using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Cotizaciones.Modelos;

namespace Cotizaciones.Datos
{
    class ServicioDatos
    {
        public Boolean Agregar(Servicio servicio)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_cotizacion = servicio.Id_cotizacion;
                string nombre = servicio.Nombre;
                int costo = servicio.Costo;
                int tiempo = servicio.Tiempo;
                int tipo_tiempo = servicio.Tipo_tiempo;

                var query = new SQLiteCommand("INSERT INTO servicios(id_cotizacion, nombre, costo, tiempo, tipo_tiempo) VALUES (@p0, @p1, @p2, @p3, @p4)", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cotizacion);
                query.Parameters.AddWithValue("@p1", nombre);
                query.Parameters.AddWithValue("@p2", costo);
                query.Parameters.AddWithValue("@p3", tiempo);
                query.Parameters.AddWithValue("@p4", tipo_tiempo);

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

        public Boolean Editar(Servicio servicio)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_servicio = servicio.Id_servicio;
                int id_cotizacion = servicio.Id_cotizacion;
                string nombre = servicio.Nombre;
                int costo = servicio.Costo;
                int tiempo = servicio.Tiempo;
                int tipo_tiempo = servicio.Tipo_tiempo;

                var query = new SQLiteCommand("UPDATE servicios SET id_cotizacion = @p0, nombre = @p1, costo = @p2, tiempo = @p3, tipo_tiempo = @p4 WHERE id_servicio = @p5", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_cotizacion);
                query.Parameters.AddWithValue("@p1", nombre);
                query.Parameters.AddWithValue("@p2", costo);
                query.Parameters.AddWithValue("@p3", tiempo);
                query.Parameters.AddWithValue("@p4", tipo_tiempo);
                query.Parameters.AddWithValue("@p5", id_servicio);

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

        public Boolean Borrar(int id_servicio)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM servicios where id_servicio = @p0", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_servicio);

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

        public Boolean BorrarPorCotizacion(int id_cotizacion)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM servicios where id_cotizacion = @p0", conexion.conexion);

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

        public ArrayList cargarServicios(int id_cotizacion)
        {
            ArrayList listaServicios = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT id_servicio, id_cotizacion, nombre, costo, tiempo, tipo_tiempo FROM servicios WHERE id_cotizacion = @p0",conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_cotizacion);

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                Servicio servicio = new Servicio();
                if (!reader.IsDBNull(0))
                {
                    servicio.Id_servicio = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    servicio.Id_cotizacion = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    servicio.Nombre = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    servicio.Costo = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    servicio.Tiempo = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    servicio.Tipo_tiempo= reader.GetInt32(5);
                }
                listaServicios.Add(servicio);
            }
            reader.Close();
            conexion.cerrar();
            return listaServicios;
        }

        public Servicio cargarServicio(int id_servicio)
        {
            Servicio servicio = new Servicio();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT id_servicio, id_cotizacion, nombre, costo, tiempo, tipo_tiempo FROM servicios WHERE id_servicio = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_servicio);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    servicio.Id_servicio = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    servicio.Id_cotizacion = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    servicio.Nombre = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    servicio.Costo = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    servicio.Tiempo = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    servicio.Tipo_tiempo = reader.GetInt32(5);
                }
            }
            reader.Close();
            conexion.cerrar();
            return servicio;
        }
    }
}
