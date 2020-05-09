using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizaciones
{
    class Configuracion
    {
        int id_configuracion;
        string nombre;
        string email;
        string presentacion;
        string despedida;

        public int Id_configuracion
        {
            get
            {
                return id_configuracion;
            }

            set
            {
                id_configuracion = value;
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Presentacion
        {
            get
            {
                return presentacion;
            }

            set
            {
                presentacion = value;
            }
        }

        public string Despedida
        {
            get
            {
                return despedida;
            }

            set
            {
                despedida = value;
            }
        }
    }
}
