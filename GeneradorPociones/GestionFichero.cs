using System.Collections.Generic;
using System;
// -----
using System.IO;
using System.Xml;

namespace GeneradorPociones
{
    class GestionFichero
    {
        static string separador = Path.DirectorySeparatorChar.ToString();
        static string rutaFicheroPocimas = @"..\..\listaParametros.txt";
        static string ficheroOS = @"..\..\listaOS.txt";
        static string ficheroETIS = @"..\..\listaOS.txt";
        public static string[] lineas;

        public static string[] efectoPrim;
        public static string[] efectoSec;
        public static string[] listaOS;
        public static string[] listaEtis;

        public static void LeerFichero()
        {
            string todo = File.ReadAllText(rutaFicheroPocimas);
            lineas = todo.Split('-');

            efectoPrim = lineas[0].Split(';');
            efectoSec = lineas[1].Split(';');

            listaOS = File.ReadAllLines(ficheroOS);
            listaEtis = File.ReadAllLines(ficheroETIS);

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

                if (item.Etiqueta != null)
                {
                    XmlNode nodoEtiqueta = escritor.CreateElement("etiqueta");
                    nodoEtiqueta.InnerText = item.Etiqueta;
                    pocion.AppendChild(nodoEtiqueta);

                    XmlNode nodoContenedor = escritor.CreateElement("contenedor");
                    nodoContenedor.InnerText = item.Contenedor;
                    pocion.AppendChild(nodoContenedor);
                }

                if (item.Textura != null)
                {
                    XmlNode nodoTextura = escritor.CreateElement("textura");
                    nodoTextura.InnerText = item.Textura;
                    pocion.AppendChild(nodoTextura);
                    XmlNode nodoOlor = escritor.CreateElement("olor");
                    nodoOlor.InnerText = item.Olor;
                    pocion.AppendChild(nodoOlor);
                    XmlNode nodoSabor = escritor.CreateElement("sabor");
                    nodoSabor.InnerText = item.Sabor;
                    pocion.AppendChild(nodoSabor);
                }

                if (item.Detalle != null)
                {
                    XmlNode nodoDetalle = escritor.CreateElement("detalle");
                    nodoDetalle.InnerText = item.Detalle;
                    pocion.AppendChild(nodoDetalle);
                }


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

            XmlElement header = escritorHTML.CreateElement("h1");
            header.InnerText = "Pociones";
            body.AppendChild(header);

            XmlElement estiloTablas = escritorHTML.CreateElement("style");
            XmlAttribute tipoEstilo = escritorHTML.CreateAttribute("type");
            tipoEstilo.Value = "text / css";
            estiloTablas.Attributes.Append(tipoEstilo);

            // Clase CSS
            XmlAttribute clase = escritorHTML.CreateAttribute("class");
            clase.Value = "tg-14nr";
            // Otros atributos
            XmlAttribute cols2 = escritorHTML.CreateAttribute("colspan");
            clase.Value = "2";
            XmlAttribute cols3 = escritorHTML.CreateAttribute("colspan");
            clase.Value = "3";

            estiloTablas.InnerText = @" .tg  {border-collapse:collapse;border-spacing:0;}
                                        .tg td { font - family:Arial, sans - serif; font - size:14px; padding: 10px 20px; border - style:solid; border - width:1px; overflow: hidden; word -break:normal;}
                                        .tg th{ font - family:Arial, sans - serif; font - size:14px; font - weight:normal; padding: 10px 20px; border - style:solid; border - width:1px; overflow: hidden; word -break:normal;}
                                        .tg.tg - baqh { text - align:center; vertical - align:top}
                                        .tg.tg - 14nr { background - color:#bbdaff;text-align:center;vertical-align:top}";
 
            foreach (Pocion item in lista)
            {
                // TABLE y HEADERS
                XmlNode tabla = escritorHTML.CreateElement("table");

                XmlNode fila1 = escritorHTML.CreateElement("tr");

                XmlNode thTipo = escritorHTML.CreateElement("td");
                thTipo.AppendChild(clase);
                thTipo.InnerText = "Tipo";
                XmlNode thEfectoP = escritorHTML.CreateElement("td");
                thEfectoP.AppendChild(clase);
                thEfectoP.AppendChild(cols2);
                thTipo.InnerText = "Efecto primario";

                fila1.AppendChild(thTipo);
                fila1.AppendChild(thEfectoP);

                tabla.AppendChild(fila1);

                XmlNode fila2 = escritorHTML.CreateElement("tr");
                // Item TEp

                XmlNode fila3 = escritorHTML.CreateElement("tr");

                XmlNode thPoder = escritorHTML.CreateElement("td");
                thPoder.AppendChild(clase);
                thPoder.InnerText = "Poder";
                XmlNode thEfectoS = escritorHTML.CreateElement("td");
                thEfectoS.AppendChild(clase);
                thEfectoS.InnerText = "Efecto secundario";
                XmlNode thColor = escritorHTML.CreateElement("td");
                thColor.AppendChild(clase);
                thColor.InnerText = "Color";

                fila3.AppendChild(thPoder);
                fila3.AppendChild(thEfectoS);
                fila3.AppendChild(thColor);

                tabla.AppendChild(fila3);

                XmlNode fila4 = escritorHTML.CreateElement("tr");
                // Item PEsC

                if (item.Contenedor != null)
                {

                    XmlNode fila5 = escritorHTML.CreateElement("tr");

                    XmlElement thContenedor = escritorHTML.CreateElement("td");
                    thContenedor.AppendChild(clase);
                    thContenedor.InnerText = "Contenedor";
                    XmlElement thEtiqueta = escritorHTML.CreateElement("td");
                    thEtiqueta.AppendChild(clase);
                    thEtiqueta.AppendChild(cols2);
                    thEtiqueta.InnerText = "Etiqueta";

                    fila5.AppendChild(thContenedor);
                    fila5.AppendChild(thEtiqueta);

                    tabla.AppendChild(fila5);

                    XmlNode fila6 = escritorHTML.CreateElement("tr");
                    // Item CE

                }

                if (item.Textura != null)
                {

                    XmlNode fila7 = escritorHTML.CreateElement("tr");

                    XmlElement tdTextura = escritorHTML.CreateElement("td");
                    tdTextura.AppendChild(clase);
                    tdTextura.InnerText = "Textura";
                    XmlElement tdOlor = escritorHTML.CreateElement("td");
                    tdOlor.AppendChild(clase);
                    tdOlor.InnerText = "Olor";
                    XmlElement tdSabor = escritorHTML.CreateElement("td");
                    tdSabor.AppendChild(clase);
                    tdSabor.InnerText = "Sabor";

                    fila7.AppendChild(tdTextura);
                    fila7.AppendChild(tdOlor);
                    fila7.AppendChild(tdSabor);

                    tabla.AppendChild(fila7);


                    XmlNode fila8 = escritorHTML.CreateElement("tr");
                    // Item TOS
                }

                if (item.Detalle != null)
                {
                    XmlNode fila9 = escritorHTML.CreateElement("tr");

                    XmlElement thDetalle = escritorHTML.CreateElement("td");
                    thDetalle.AppendChild(clase);
                    thDetalle.AppendChild(cols3);
                    thDetalle.InnerText = "Detalle";

                    fila9.AppendChild(thDetalle);

                    tabla.AppendChild(fila9);

                    XmlNode fila10 = escritorHTML.CreateElement("tr");
                    // Item detalle
                }
                //Salto de linea
                XmlNode nl = escritorHTML.CreateElement("br");
                body.AppendChild(nl);

                body.AppendChild(tabla);
            }

            escritorHTML.Save(rutaFinal);
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
                    item.Color + nl;

                if (item.Textura != null)
                {
                    texto += 
                        item.Textura + nl +
                        item.Olor + nl +
                        item.Sabor + nl;
                }

                if (item.Contenedor != null)
                {
                    texto +=
                        item.Contenedor + nl +
                        item.Etiqueta + nl;
                }

                if (item.Detalle != null)
                    texto += item.Detalle + nl;

                texto += nl + nl;
            }
            File.WriteAllText(ruta, texto, System.Text.Encoding.UTF8);
        }


    }
}
