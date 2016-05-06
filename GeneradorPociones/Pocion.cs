using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ---
using System.IO;

namespace GeneradorPociones
{
    class Pocion
    {
        // Campos
        string _tipo;
        string _color;
        string _detalle;
        string _efectoPrim;
        string _efectoSec;
        string _poder;
        string _textura;

        #region Propiedades

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public string Detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
            }
        }

        public string EfectoPrim
        {
            get
            {
                return _efectoPrim;
            }

            set
            {
                _efectoPrim = value;
            }
        }

        public string EfectoSec
        {
            get
            {
                return _efectoSec;
            }

            set
            {
                _efectoSec = value;
            }
        }

        public string Poder
        {
            get
            {
                return _poder;
            }

            set
            {
                _poder = value;
            }
        }

        public string Textura
        {
            get
            {
                return _textura;
            }

            set
            {
                _textura = value;
            }
        } 
        #endregion


        // Constructores
        public Pocion()
        {
            this.Tipo = GestionFichero.tipo[new Random().Next(0, GestionFichero.tipo.Length)].ToString();
            this.Poder = GestionFichero.poder[new Random().Next(0, GestionFichero.poder.Length)].ToString();
            this.EfectoPrim = GestionFichero.efectoPrim[new Random().Next(0, GestionFichero.efectoPrim.Length)].ToString();
            this.EfectoSec = GestionFichero.efectoSec[new Random().Next(0, GestionFichero.efectoSec.Length)].ToString();
            this.Color = GestionFichero.aspectoPrim[new Random().Next(0, GestionFichero.aspectoPrim.Length)].ToString();
            this.Detalle = GestionFichero.aspectoSec[new Random().Next(0, GestionFichero.aspectoSec.Length)].ToString();
            this.Textura = GestionFichero.textura[new Random().Next(0, GestionFichero.textura.Length)].ToString();
        }
    }
}
