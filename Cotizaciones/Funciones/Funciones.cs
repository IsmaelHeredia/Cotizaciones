using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Cotizaciones
{
    class Funciones
    {
        public string cargarNombreTipoTiempo(int tipoTiempo, int cantidad)
        {
            string nombre = "";
            if (tipoTiempo == 1)
            {
                if (cantidad == 1)
                {
                    nombre = "Minuto";
                }
                else
                {
                    nombre = "Minutos";
                }
            }
            else if (tipoTiempo == 60)
            {
                if (cantidad == 1)
                {
                    nombre = "Hora";
                }
                else
                {
                    nombre = "Horas";
                }
            }
            else if (tipoTiempo == 1440)
            {
                if (cantidad == 1)
                {
                    nombre = "Día";
                }
                else
                {
                    nombre = "Días";
                }
            }
            else if (tipoTiempo == 10080)
            {
                if (cantidad == 1)
                {
                    nombre = "Semana";
                }
                else
                {
                    nombre = "Semanas";
                }
            }
            else if (tipoTiempo == 43800)
            {
                if (cantidad == 1)
                {
                    nombre = "Mes";
                }
                else
                {
                    nombre = "Meses";
                }
            }
            else if (tipoTiempo == 525600)
            {
                if (cantidad == 1)
                {
                    nombre = "Año";
                }
                else
                {
                    nombre = "Años";
                }
            }
            return nombre.ToLower();
        }

        public int cargarValorTiempo(string nombre)
        {
            int valor = 0;
            if (nombre == "Minutos")
            {
                valor = 1;
            }
            else if (nombre == "Horas")
            {
                valor = 60;
            }
            else if (nombre == "Días")
            {
                valor = 1440;
            }
            else if (nombre == "Semanas")
            {
                valor = 10080;
            }
            else if (nombre == "Meses")
            {
                valor = 43800;
            }
            else if (nombre == "Años")
            {
                valor = 525600;
            }
            return valor;
        }

        public string sumarTotalTiempo(int minutos_total)
        {
            string resultado = "";
            int segundos_total = minutos_total * 60 / 1;
            TimeSpan diff = TimeSpan.FromSeconds(segundos_total);

            int años = diff.Days / 365;
            int meses = (diff.Days - (diff.Days / 365) * 365) / 30;
            int dias = (diff.Days - (diff.Days / 365) * 365) - ((diff.Days - (diff.Days / 365) * 365) / 30) * 30;
            int horas = diff.Hours;
            int minutos = diff.Minutes;
            int segundos = diff.Seconds;

            if(años != 0)
            {
                if(años == 1)
                {
                    resultado += años + " año, ";
                } else
                {
                    resultado += años + " años, ";
                }
            }

            if (meses != 0)
            {
                if (meses == 1)
                {
                    resultado += meses + " mes, ";
                }
                else
                {
                    resultado += meses + " meses, ";
                }
            }

            if (dias != 0)
            {
                if (dias == 1)
                {
                    resultado += dias + " día, ";
                }
                else
                {
                    resultado += dias + " días, ";
                }
            }

            if (horas != 0)
            {
                if (horas == 1)
                {
                    resultado += horas + " hora, ";
                }
                else
                {
                    resultado += horas + " horas, ";
                }
            }

            if (minutos != 0)
            {
                if (minutos == 1)
                {
                    resultado += minutos + " minuto, ";
                }
                else
                {
                    resultado += minutos + " minutos, ";
                }
            }

            resultado = resultado.Substring(0, resultado.Length - 2);

            /*
            string tostring = string.Format(
                CultureInfo.CurrentCulture,
                "{0} años, {1} meses, {2} dias, {3} horas, {4} minutos, {5} segundos",
                años, meses, dias, horas, minutos, segundos);
           */

            return resultado;
        }
    }
}
