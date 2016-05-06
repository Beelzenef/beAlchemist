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

        List<Pocion> listaPoc = new List<Pocion>();

        private void GenerarPocima(object sender, EventArgs e)
        {
            lbl_NPociones.Text = contadorPociones++.ToString();
            // Generando pociones

            Pocion unaPocion = new Pocion();
            lsB_Resultados.Items.Add("Tipo: " + unaPocion.Tipo);
            lsB_Resultados.Items.Add("Poder: " + unaPocion.Poder);
            lsB_Resultados.Items.Add("Efecto primario: " + unaPocion.EfectoPrim);
            lsB_Resultados.Items.Add("Efecto secundario: " + unaPocion.EfectoSec);
            lsB_Resultados.Items.Add("Color: " + unaPocion.Color);
            lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
            lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura);

            lsB_Resultados.Items.Add("");

            listaPoc.Add(unaPocion);
        }

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
            GestionFichero.GenerarXML(listaPoc, sFD_GuardarXML.FileName);
        }

        private void genHTML_MenuItem_Click(object sender, EventArgs e)
        {
            if (sFD_GuardarHTML.ShowDialog() != DialogResult.OK)
                return;
            GestionFichero.GenerarXML(listaPoc, "tmp.xml");
            //GestionFichero.GenerarHTML(sFD_GuardarHTML.FileName);
        }

    }
}
