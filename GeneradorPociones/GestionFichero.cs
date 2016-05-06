using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// -----
using System.IO;
using System.Collections;

namespace GeneradorPociones
{
    class GestionFichero
    {
        public static string separador = Path.DirectorySeparatorChar.ToString();
        public static string rutaFicheroPocimas = @"..\..\listaParametros.txt";
        public static string[] lineas;
        public static string[] tipo;
        public static string[] efectoPrim;
        public static string[] aspectoPrim;
        public static string[] aspectoSec;
        public static string[] textura;
        public static string[] efectoSec;
        public static string[] poder;

        public static void LeerFichero()
        {
            string todo = File.ReadAllText(rutaFicheroPocimas);
            lineas = todo.Split('-');

            tipo = lineas[0].Split(';');
            efectoPrim = lineas[1].Split(';');
            aspectoPrim = lineas[2].Split(';');
            aspectoSec = lineas[3].Split(';');
            textura = lineas[4].Split(';');
            efectoSec = lineas[5].Split(';');
            poder = lineas[5].Split(';');

        }
    }
}
