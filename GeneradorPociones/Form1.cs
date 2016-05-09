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
            contadorPociones++;
            lbl_NPociones.Text = contadorPociones.ToString();
            // Generando pociones

            Pocion unaPocion = new Pocion();
            lsB_Resultados.Items.Add("Tipo: " + unaPocion.Tipo);
            lsB_Resultados.Items.Add("Poder: " + unaPocion.Poder);
            lsB_Resultados.Items.Add("Efecto: " + unaPocion.EfectoPrim);
            lsB_Resultados.Items.Add("Efecto secundario: " + unaPocion.EfectoSec);
            lsB_Resultados.Items.Add("Color: " + unaPocion.Color);
            lsB_Resultados.Items.Add("Detalles: " + unaPocion.Detalle);
            lsB_Resultados.Items.Add("Textura: " + unaPocion.Textura);

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
            GestionFichero.GenerarXML(listaPoc, sFD_GuardarXML.FileName);
        }

        private void genHTML_MenuItem_Click(object sender, EventArgs e)
        {
            if (sFD_GuardarHTML.ShowDialog() != DialogResult.OK)
                return;
            GestionFichero.GenerarXML(listaPoc, "tmp.xml");
            //GestionFichero.GenerarHTML(sFD_GuardarHTML.FileName);
        } 

        #endregion

        #region Modificando constructor

        bool incluirTextura = false;
        bool incluirOlor = false;
        bool incluirSabor = false;
        bool incluirEtiqueta = false;
        bool incluirContenedor = false;
        bool incluirDetalles = false;

        private void chkLSB_Elementos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chkLSB_Elementos.SelectedIndex == 0)
                incluirContenedor = !incluirContenedor;
            if (chkLSB_Elementos.SelectedIndex == 1)
                incluirDetalles = !incluirDetalles;
            if (chkLSB_Elementos.SelectedIndex == 2)
                incluirTextura = !incluirTextura;
            if (chkLSB_Elementos.SelectedIndex == 3)
                incluirOlor = !incluirOlor;
            if (chkLSB_Elementos.SelectedIndex == 4)
                incluirSabor = !incluirSabor;
            if (chkLSB_Elementos.SelectedIndex == 5)
                incluirEtiqueta = !incluirEtiqueta;
        }

        #endregion
    }
}
