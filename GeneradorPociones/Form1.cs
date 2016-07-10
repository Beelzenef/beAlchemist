using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneradorPociones
{
    public partial class formPociones : Form
    {
        public formPociones()
        {
            InitializeComponent();
            GestionFichero.LeerFichero();
        }

        int contadorPociones = 0;
        int marcandoOpciones = 0;

        List<Pocion> listaPoc = new List<Pocion>();

        private void GenerarPocima(object sender, EventArgs e)
        {
            contadorPociones++;
            lbl_NPociones.Text = contadorPociones.ToString();
            // Generando pociones

            Pocion unaPocion = new Pocion(marcandoOpciones);
            lsB_Resultados.Items.Add("Tipo: " + unaPocion.Tipo);
            lsB_Resultados.Items.Add("Poder: " + unaPocion.Poder);
            lsB_Resultados.Items.Add("Efecto: " + unaPocion.EfectoPrim);
            lsB_Resultados.Items.Add("Efecto secundario: " + unaPocion.EfectoSec);
            lsB_Resultados.Items.Add("Color: " + unaPocion.Color);

            switch (marcandoOpciones)
            {
                case 1:
                    lsB_Resultados.Items.Add("Un " + unaPocion.Contenedor + " que reza " + unaPocion.Etiqueta);
                    break;
                case 2:
                    lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura + ", olor: " + unaPocion.Olor + ", sabor: " + unaPocion.Sabor);
                    break;
                case 3:
                    lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura + ", olor: " + unaPocion.Olor + ", sabor: " + unaPocion.Sabor);
                    lsB_Resultados.Items.Add("Un " + unaPocion.Contenedor + " que reza " + unaPocion.Etiqueta);
                    break;
                case 4:
                    lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
                    break;
                case 5:
                    lsB_Resultados.Items.Add("Un " + unaPocion.Contenedor + " que reza " + unaPocion.Etiqueta);
                    lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
                    break;
                case 6:
                    lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
                    lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura + ", olor: " + unaPocion.Olor + ", sabor: " + unaPocion.Sabor);
                    break;
                case 7:
                    lsB_Resultados.Items.Add("Un " + unaPocion.Contenedor + " que reza " + unaPocion.Etiqueta);
                    lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
                    lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura + ", olor: " + unaPocion.Olor + ", sabor: " + unaPocion.Sabor);
                    break;
            }

            lsB_Resultados.Items.Add("");
            listaPoc.Add(unaPocion);
        }


        #region Gestion de menu

        private void nuevo_MenuItem_Click(object sender, EventArgs e)
        {
            lsB_Resultados.Items.Clear();
        }

        private void info_MenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://geekstorming.wordpress.com");
        }

        private void genXML_MenuItem_Click(object sender, EventArgs e)
        {
            if (sFD_GuardarXML.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                GestionFichero.GenerarXML(listaPoc, sFD_GuardarXML.FileName);
            }
            catch
            {
                MessageBox.Show("Imposible guardar, ¿está abierto el fichero?");
            }
            sFD_GuardarXML.FileName = "Fichero XML";
        }


        private void genHTML_MenuItem_Click(object sender, EventArgs e)
        {
            if (sFD_GuardarHTML.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                GestionFichero.GenerarHTML(listaPoc, sFD_GuardarHTML.FileName);
            }
            catch
            {
                MessageBox.Show("Imposible guardar, ¿está abierto el fichero?");
            }
            sFD_GuardarHTML.FileName = "Fichero HTM(L)";
        }

        private void genRTF_MenuItem_Click(object sender, EventArgs e)
        {
            if (sFD_GuardarRTF.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                GestionFichero.GenerarRTF(listaPoc, sFD_GuardarRTF.FileName);
            }
            catch
            {
                MessageBox.Show("Imposible guardar, ¿está abierto el fichero?");
            }
            sFD_GuardarRTF.FileName = "Fichero RTF";
        }

        private void genPDF_MenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Modificando constructor        

        private void chkB_CE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_CE.Checked)
                marcandoOpciones += 1;
            else
                marcandoOpciones -= 1;
        }

        private void chkB_TOS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_TOS.Checked)
                marcandoOpciones += 2;
            else
                marcandoOpciones -= 2;
        }

        private void chkB_Detalles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Detalles.Checked)
                marcandoOpciones += 4;
            else
                marcandoOpciones -= 4;
        }

        #endregion
    }
}
