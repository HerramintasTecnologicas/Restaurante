
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Clases
{
    class ConversionNumerosLetras
    {
        public static string Letras(string numero)
        {
            string resultado, dec = "";
            Int64 entero;
            int decimales;
            double Numero;

            try

            {
                Numero = Convert.ToDouble(numero);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(Numero));
            decimales = Convert.ToInt32(Math.Round((Numero - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + Conversion(decimales) + " CENTAVOS";
                resultado = Conversion(Convert.ToDouble(entero)) + " LEMPIRAS" + dec;
            }
            else
            {
                resultado = Conversion(Convert.ToDouble(Numero)) + " LEMPIRAS EXACTOS";
            }
            return resultado;
        }

        private static string Conversion(double valor)
        {
            string Valor = "";
            valor = Math.Truncate(valor);
            if (valor == 0) Valor = "CERO";
            else if (valor == 1) Valor = "UNO";
            else if (valor == 2) Valor = "DOS";
            else if (valor == 3) Valor = "TRES";
            else if (valor == 4) Valor = "CUATRO";
            else if (valor == 5) Valor = "CINCO";
            else if (valor == 6) Valor = "SEIS";
            else if (valor == 7) Valor = "SIETE";
            else if (valor == 8) Valor = "OCHO";
            else if (valor == 9) Valor = "NUEVE";
            else if (valor == 10) Valor = "DIEZ";
            else if (valor == 11) Valor = "ONCE";
            else if (valor == 12) Valor = "DOCE";
            else if (valor == 13) Valor = "TRECE";
            else if (valor == 14) Valor = "CATORCE";
            else if (valor == 15) Valor = "QUINCE";
            else if (valor < 20) Valor = "DIECI" + Conversion(valor - 10);
            else if (valor == 20) Valor = "VEINTE";
            else if (valor < 30) Valor = "VEINTI" + Conversion(valor - 20);
            else if (valor == 30) Valor = "TREINTA";
            else if (valor == 40) Valor = "CUARENTA";
            else if (valor == 50) Valor = "CINCUENTA";
            else if (valor == 60) Valor = "SESENTA";
            else if (valor == 70) Valor = "SETENTA";
            else if (valor == 80) Valor = "OCHENTA";
            else if (valor == 90) Valor = "NOVENTA";
            else if (valor < 100) Valor = Conversion(Math.Truncate(valor / 10) * 10) + " Y " + Conversion(valor % 10);
            else if (valor == 100) Valor = "CIEN";
            else if (valor < 200) Valor = "CIENTO " + Conversion(valor - 100);
            else if ((valor == 200) || (valor == 300) || (valor == 400) || (valor == 600) || (valor == 800)) Valor = Conversion(Math.Truncate(valor / 100)) + "CIENTOS";
            else if (valor == 500) Valor = "QUINIENTOS";
            else if (valor == 700) Valor = "SETECIENTOS";
            else if (valor == 900) Valor = "NOVECIENTOS";
            else if (valor < 1000) Valor = Conversion(Math.Truncate(valor / 100) * 100) + " " + Conversion(valor % 100);
            else if (valor == 1000) Valor = "MIL";
            else if (valor < 2000) Valor = "MIL " + Conversion(valor % 1000);
            else if (valor < 1000000)
            {
                Valor = Conversion(Math.Truncate(valor / 1000)) + " MIL";
                if ((valor % 1000) > 0) Valor = Valor + " " + Conversion(valor % 1000);
            }

            else if (valor == 1000000) Valor = "UN MILLON";
            else if (valor < 2000000) Valor = "UN MILLON " + Conversion(valor % 1000000);
            else if (valor < 1000000000000)
            {
                Valor = Conversion(Math.Truncate(valor / 1000000)) + " MILLONES ";
                if ((valor - Math.Truncate(valor / 1000000) * 1000000) > 0) Valor = Valor + " " + Conversion(valor - Math.Truncate(valor / 1000000) * 1000000);
            }

            else if (valor == 1000000000000) Valor = "UN BILLON";
            else if (valor < 2000000000000) Valor = "UN BILLON " + Conversion(valor - Math.Truncate(valor / 1000000000000) * 1000000000000);

            else
            {
                Valor = Conversion(Math.Truncate(valor / 1000000000000)) + " BILLONES";
                if ((valor - Math.Truncate(valor / 1000000000000) * 1000000000000) > 0) Valor = Valor + " " + Conversion(valor - Math.Truncate(valor / 1000000000000) * 1000000000000);
            }
            return Valor;
        }
    }
}
