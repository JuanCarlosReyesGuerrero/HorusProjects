using System;
using System.Web;

namespace Horus.Common.Utilidades
{
    public class classUtilidades
    {
        #region PROCEDIMIENTOS

        /// <summary>
        /// Muestra un mensaje en el equipo cliente
        /// </summary>
        /// <param name="vMensaje">Es el mensaje que se muestra al usuario</param>
        /// <param name="response"></param>
        public void MostrarMensaje(string vMensaje, HttpResponse response)
        {
            string nl = System.Environment.NewLine;

            vMensaje = vMensaje.Replace("'", "\"");
            //vMensaje = vMensaje.Replace(vbCrLf, "\\n");
            vMensaje = vMensaje.Replace(nl, "\\n");
            string script = "<script>window.alert('" + vMensaje + "');</script>";
            response.Write(script);
        }

        #endregion

        #region FUNCIONES

        /// <summary>
        /// Calcula la edad.
        /// </summary>
        /// <param name="vFechaNacimiento">The v fecha nacimiento.</param>
        /// <param name="vFechaActual">The v fecha actual.</param>
        /// <returns></returns>
        public string CalcularEdad(DateTime vFechaNacimiento, DateTime vFechaActual)
        {
            if (vFechaNacimiento.Date > vFechaActual.Date)
            {
                //MessageBox.Show("La fecha de nacimiento debe ser mayor o igual a la fecha actual.", "QSalud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int years = vFechaActual.Year - vFechaNacimiento.Year;
            int months = 0;
            int days = 0;

            // Compruebe si el último año, fue un año completo.
            if (vFechaActual < vFechaNacimiento.AddYears(years) && years != 0)
            {
                years--;
            }

            // Calcular el número de meses.
            vFechaNacimiento = vFechaNacimiento.AddYears(years);

            if (vFechaNacimiento.Year == vFechaActual.Year)
            {
                months = vFechaActual.Month - vFechaNacimiento.Month;
            }
            else
            {
                months = (12 - vFechaNacimiento.Month) + vFechaActual.Month;
            }

            // Compruebe si el mes pasado fue un mes completo.
            if (vFechaActual < vFechaNacimiento.AddMonths(months) && months != 0)
            {
                months--;
            }

            // Calcular el número de días.
            vFechaNacimiento = vFechaNacimiento.AddMonths(months);

            days = (vFechaActual - vFechaNacimiento).Days;

            string vEdad = string.Empty;
            vEdad = years + " Años " + months + " Meses " + days + " Días";

            return vEdad;
        }

        #endregion
    }
}
