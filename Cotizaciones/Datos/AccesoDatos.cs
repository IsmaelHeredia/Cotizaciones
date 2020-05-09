using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace Cotizaciones.Datos
{
    class AccesoDatos
    {
        public AccesoDatos()
        {
        }

        public Boolean crearBD()
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string sql_crear_tabla_configuracion = "CREATE TABLE IF NOT EXISTS configuracion(id_configuracion integer PRIMARY KEY autoincrement,nombre nvarchar(100),email nvarchar(100), presentacion nvarchar(100), despedida nvarchar(100));";

                SQLiteCommand cmd_crear_tabla_configuracion = new SQLiteCommand(sql_crear_tabla_configuracion, conexion.conexion);
                cmd_crear_tabla_configuracion.ExecuteNonQuery();

                string sql_crear_tabla_clientes = "CREATE TABLE IF NOT EXISTS clientes(id_cliente integer PRIMARY KEY autoincrement,nombre nvarchar(100),email nvarchar(100));";

                SQLiteCommand cmd_crear_tabla_clientes = new SQLiteCommand(sql_crear_tabla_clientes, conexion.conexion);
                cmd_crear_tabla_clientes.ExecuteNonQuery();

                string sql_crear_tabla_cotizaciones = "CREATE TABLE IF NOT EXISTS cotizaciones(id_cotizacion integer PRIMARY KEY autoincrement, id_cliente int, titulo nvarchar(100),descripcion nvarchar(100), moneda nvarchar(100), fecha nvarchar(100),constraint fk_cotizaciones foreign key (id_cliente) references clientes(id_cliente));";

                SQLiteCommand cmd_crear_tabla_cotizaciones = new SQLiteCommand(sql_crear_tabla_cotizaciones, conexion.conexion);
                cmd_crear_tabla_cotizaciones.ExecuteNonQuery();

                string sql_crear_tabla_servicios = "CREATE TABLE IF NOT EXISTS servicios(id_servicio integer PRIMARY KEY autoincrement, id_cotizacion int, nombre nvarchar(100),costo integer, tiempo int, tipo_tiempo int, constraint fk_servicios foreign key (id_cotizacion) references cotizaciones(id_cotizacion));";

                SQLiteCommand cmd_crear_tabla_servicios = new SQLiteCommand(sql_crear_tabla_servicios, conexion.conexion);
                cmd_crear_tabla_servicios.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return respuesta;
        }
    }
}
