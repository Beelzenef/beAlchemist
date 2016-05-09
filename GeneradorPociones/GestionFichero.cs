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

        public static string[] efectoPrim;
        public static string[] efectoSec;

        public static void LeerFichero()
        {
            string todo = File.ReadAllText(rutaFicheroPocimas);
            lineas = todo.Split('-');

            efectoPrim = lineas[0].Split(';');
            efectoSec = lineas[1].Split(';');

        }

        public static void GenerarXML(List<Pocion> lista, string ruta)
        {
            XmlDocument escritor = new XmlDocument();

            // Declaracion de raíz del documento
            XmlDeclaration declaracion = escritor.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement raiz = escritor.DocumentElement;
            escritor.InsertBefore(declaracion, raiz);

            // Elemento pociones
            XmlElement nodoPociones = escritor.CreateElement("pociones");
            escritor.AppendChild(nodoPociones);


            foreach (Pocion item in lista)
            {
                // Creando elemento pocion 
                XmlNode pocion = escritor.CreateElement("pocion");


                // Generando elementos 
                XmlNode nodoTipo = escritor.CreateElement("tipo");
                nodoTipo.InnerText = item.Tipo;
                pocion.AppendChild(nodoTipo);
                XmlNode nodoPoder = escritor.CreateElement("poder");
                nodoPoder.InnerText = item.Poder;
                pocion.AppendChild(nodoPoder);
                XmlNode nodoEfectoP = escritor.CreateElement("efectoP");
                nodoEfectoP.InnerText = item.EfectoPrim;
                pocion.AppendChild(nodoEfectoP);
                XmlNode nodoEfectoS = escritor.CreateElement("efectoS");
                nodoEfectoS.InnerText = item.EfectoSec;
                pocion.AppendChild(nodoEfectoS);
                XmlNode nodoColor = escritor.CreateElement("color");
                nodoColor.InnerText = item.Color;
                pocion.AppendChild(nodoColor);
                XmlNode nodoDetalle = escritor.CreateElement("detalle");
                nodoDetalle.InnerText = item.Detalle;
                pocion.AppendChild(nodoDetalle);
                XmlNode nodoTextura = escritor.CreateElement("textura");
                nodoTextura.InnerText = item.Textura;
                pocion.AppendChild(nodoTextura);
                
                // Agregando la pocion al elemento pociones una vez completo
                nodoPociones.AppendChild(pocion);

            }
            // Guardando fichero
            escritor.Save(ruta);
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
