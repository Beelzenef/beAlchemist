using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void nuevo_MenuItem_Click(object sender, EventArgs e)
        {
            lsB_Resultados.Items.Clear();
        }

        private void info_MenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://geekstorming.wordpress.com");
        }
    }
}
