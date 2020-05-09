using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizaciones.Modelos
{
    class Servicio
    {
        int id_servicio;
        int id_cotizacion;
        string nombre;
        int costo;
        int tiempo;
        int tipo_tiempo;

        public int Id_servicio
        {
            get
            {
                return id_servicio;
            }

            set
            {
                id_servicio = value;
            }
        }

        public int Id_cotizacion
        {
            get
            {
                return id_cotizacion;
            }

            set
            {
                id_cotizacion = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public int Tiempo
        {
            get
            {
                return tiempo;
            }

            set
            {
                tiempo = value;
            }
        }

        public int Tipo_tiempo
        {
            get
            {
                return tipo_tiempo;
            }

            set
            {
                tipo_tiempo = value;
            }
        }
    }
}
