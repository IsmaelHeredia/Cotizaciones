using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizaciones.Modelos
{
    class Cotizacion
    {
        int id_cotizacion;
        int id_cliente;
        string nombre_cliente;
        string titulo;
        string descripcion;
        string moneda;
        string fecha;

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

        public int Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
            }
        }

        public string Nombre_cliente
        {
            get
            {
                return nombre_cliente;
            }

            set
            {
                nombre_cliente = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }
}
