using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizaciones.Modelos
{
    class Cliente
    {
        int id_cliente;
        string nombre;
        string email;

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
    }
}
