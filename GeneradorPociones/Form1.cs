using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// -----
using System.IO;
using System.Collections;

namespace GeneradorPociones
{
    public partial class formPociones : Form
    {
        public formPociones()
        {
            InitializeComponent();
            LeerFichero();
        }

        string separador = Path.DirectorySeparatorChar.ToString();
        string rutaFicheroPocimas = @"..\..\listaParametros.txt";
        string[] lineas;
        string[] tipo;
        string[] efectoPrim;
        string[] aspectoPrim;
        string[] aspectoSec;
        string[] textura;

        private void LeerFichero()
        {
            string todo = File.ReadAllText(rutaFicheroPocimas);
            lineas = todo.Split('-');
            tipo = lineas[0].Split(';');
            efectoPrim = lineas[1].Split(';');
            aspectoPrim = lineas[2].Split(';');
            aspectoSec = lineas[3].Split(';');
            textura = lineas[4].Split(';');
        }

        int contadorPociones = 0;

        private void GenerarPocima(object sender, EventArgs e)
        {
                lsB_Resultados.Items.Add("-----");
                lsB_Resultados.Items.Add("Tipo: " + tipo[new Random().Next(0, tipo.Length)].ToString());
                lsB_Resultados.Items.Add("Efecto: " + efectoPrim[new Random().Next(0, efectoPrim.Length)].ToString());
                lsB_Resultados.Items.Add("Aspecto primario: " + aspectoPrim[new Random().Next(0, aspectoPrim.Length)].ToString());
                lsB_Resultados.Items.Add("Aspecto secundario: " + aspectoSec[new Random().Next(0, aspectoSec.Length)].ToString());
                lsB_Resultados.Items.Add("Textura: " + textura[new Random().Next(0, textura.Length)].ToString());
                label1.Text = contadorPociones++.ToString();
        }
    }
}
