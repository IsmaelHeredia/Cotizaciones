using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace Cotizaciones.Datos
{
    class ConfiguracionDatos
    {
        public Boolean Agregar(Configuracion configuracion)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string nombre = configuracion.Nombre;
                string email = configuracion.Email;
                string presentacion = configuracion.Presentacion;
                string despedida = configuracion.Despedida;

                var query = new SQLiteCommand("INSERT INTO configuracion(nombre, email, presentacion, despedida) VALUES (@p0, @p1, @p2, @p3)", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", email);
                query.Parameters.AddWithValue("@p2", presentacion);
                query.Parameters.AddWithValue("@p3", despedida);

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

        public Boolean Editar(Configuracion configuracion)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string nombre = configuracion.Nombre;
                string email = configuracion.Email;
                string presentacion = configuracion.Presentacion;
                string despedida = configuracion.Despedida;

                var query = new SQLiteCommand("UPDATE configuracion SET nombre = @p0, email = @p1, presentacion = @p2, despedida = @p3 WHERE id_configuracion = 1", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", email);
                query.Parameters.AddWithValue("@p2", presentacion);
                query.Parameters.AddWithValue("@p3", despedida);

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

        public Configuracion cargarConfiguracion()
        {
            Configuracion configuracion = new Configuracion();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT id_configuracion, nombre, email, presentacion, despedida FROM configuracion WHERE id_configuracion = 1", conexion.conexion);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    configuracion.Id_configuracion = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    configuracion.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    configuracion.Email = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    configuracion.Presentacion = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    configuracion.Despedida = reader.GetString(4);
                }
            }
            conexion.cerrar();
            return configuracion;
        }
    }
}
