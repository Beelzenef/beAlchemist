using System.Collections.Generic;
// -----
using System.IO;
using System.Xml;
using System.Xml.Xsl;

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
            poder = lineas[6].Split(';');

        }

        public static void GenerarXML(List<Pocion> lista, string ruta)
        {
            XmlWriter escritor = XmlWriter.Create(ruta);

            escritor.WriteStartDocument();

            escritor.WriteStartElement("pociones");

            foreach (Pocion item in lista)
            {
                escritor.WriteStartElement("pocion");

                escritor.WriteElementString("tipo", item.Tipo);
                escritor.WriteElementString("poder", item.Poder);
                escritor.WriteElementString("efecto1", item.EfectoPrim);
                escritor.WriteElementString("efecto2", item.EfectoSec);
                escritor.WriteElementString("color", item.Color);
                escritor.WriteElementString("detalles", item.Detalle);
                escritor.WriteElementString("textura", item.Textura);

                escritor.WriteEndElement();
            }

            escritor.WriteEndElement();

            escritor.WriteEndDocument();

            escritor.Close();
        }

        public static void GenerarHTML(string ruta)
        {
            string rutaXSL = @"..\..\pociones.xsl";
            Path.ChangeExtension(ruta, ".html");

            XslCompiledTransform myXslTransform = new XslCompiledTransform();
            myXslTransform.Load(rutaXSL);
            myXslTransform.Transform("temp.xml", ruta);
            File.Delete("tmp.xml");
        }


    }
}
