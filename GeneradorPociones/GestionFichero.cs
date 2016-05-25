using System.Collections.Generic;
using System;
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


            //return escritor.OuterXml;
        }

        public static void GenerarHTML(List<Pocion> lista, string rutaFinal)
        {
            XmlDocument escritorHTML = new XmlDocument();

            XmlDeclaration declaracion = escritorHTML.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement raiz = escritorHTML.DocumentElement;
            escritorHTML.InsertBefore(declaracion, raiz);

            // Elemento raiz
            XmlElement html = escritorHTML.CreateElement("html");
            escritorHTML.AppendChild(html);

            // Creando y configurando HEAD
            XmlElement head = escritorHTML.CreateElement("head");
            html.AppendChild(head);
            XmlNode titutlo = escritorHTML.CreateElement("title");
            titutlo.InnerText = "Pociones";
            head.AppendChild(titutlo);

            // Creando y configurando BODY
            XmlElement body = escritorHTML.CreateElement("body");
            html.AppendChild(body);

            foreach (Pocion item in lista)
            {
                // TABLE y HEADERS
                XmlNode tabla = escritorHTML.CreateElement("table");

                XmlAttribute borde = escritorHTML.CreateAttribute("border");
                borde.Value = "1";
                tabla.Attributes.Append(borde);
                XmlAttribute ancho = escritorHTML.CreateAttribute("width");
                ancho.Value = "80%";
                tabla.Attributes.Append(ancho);

                XmlNode filaH = escritorHTML.CreateElement("tr");

                // Añadiendo propiedades a tablas
                XmlNode Poder = escritorHTML.CreateElement("td");
                Poder.InnerText = "Poder";
                filaH.AppendChild(Poder);
                XmlNode Textura = escritorHTML.CreateElement("td");
                Textura.InnerText = "Textura";
                filaH.AppendChild(Textura);
                XmlNode Tipo = escritorHTML.CreateElement("td");
                Tipo.InnerText = "Tipo";
                filaH.AppendChild(Tipo);
                XmlNode EPrim = escritorHTML.CreateElement("td");
                EPrim.InnerText = "Efecto primario";
                filaH.AppendChild(EPrim);
                XmlNode ESec = escritorHTML.CreateElement("td");
                ESec.InnerText = "Efecto secundario";
                filaH.AppendChild(ESec);
                XmlNode Color = escritorHTML.CreateElement("td");
                Color.InnerText = "Color";
                filaH.AppendChild(Color);
                XmlNode Det = escritorHTML.CreateElement("td");
                Det.InnerText = "Detalles";
                filaH.AppendChild(Det);

                tabla.AppendChild(filaH);

                XmlNode fila = escritorHTML.CreateElement("tr");

                // Añadiendo propiedades a tablas
                XmlNode celdaPoder = escritorHTML.CreateElement("td");
                celdaPoder.InnerText = item.Poder;
                fila.AppendChild(celdaPoder);
                XmlNode celdaTextura = escritorHTML.CreateElement("td");
                celdaTextura.InnerText = item.Textura;
                fila.AppendChild(celdaTextura);
                XmlNode celdaTipo = escritorHTML.CreateElement("td");
                celdaTipo.InnerText = item.Tipo;
                fila.AppendChild(celdaTipo);
                XmlNode celdaEPrim = escritorHTML.CreateElement("td");
                celdaEPrim.InnerText = item.EfectoPrim;
                fila.AppendChild(celdaEPrim);
                XmlNode celdaESec = escritorHTML.CreateElement("td");
                celdaESec.InnerText = item.EfectoSec;
                fila.AppendChild(celdaESec);
                XmlNode celdaColor = escritorHTML.CreateElement("td");
                celdaColor.InnerText = item.Color;
                fila.AppendChild(celdaColor);
                XmlNode celdaDet = escritorHTML.CreateElement("td");
                celdaDet.InnerText = item.Detalle;
                fila.AppendChild(celdaDet);

                tabla.AppendChild(fila);
                body.AppendChild(tabla);
            }

            escritorHTML.Save(rutaFinal);
        }

        public static void CambiarRuta(string ruta)
        {
            Path.ChangeExtension(ruta, "xhtml");
        }

        public static void GuardarXML(string contenido, string ruta)
        {
            File.WriteAllText(ruta, contenido);
        }

        public static void GenerarRTF(List<Pocion> lista, string ruta)
        {
            string texto = string.Empty;
            string nl = Environment.NewLine;


            foreach (Pocion item in lista)
            {
                texto +=
                    item.Tipo + nl +
                    item.Poder + 
                    item.EfectoPrim +
                    item.EfectoSec + nl +
                    item.Color + nl +
                    item.Detalle + nl +
                    item.Textura
                    + nl + nl;
            }
            File.WriteAllText(ruta, texto, System.Text.Encoding.UTF8);
        }


    }
}
