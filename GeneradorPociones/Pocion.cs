using System;
using System.Collections;
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
        string _efectoPrim;
        string _efectoSec;
        string _poder;

        // Campos a seleccionar en checkboxes
        string _contenedor;
        string _detalle;
        string _textura;
        string _olor;
        string _sabor;
        string _etiqueta;

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

        // Props en checkboxes

        public string Contenedor
        {
            get
            {
                return _contenedor;
            }

            set
            {
                _contenedor = value;
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

        public string Olor
        {
            get
            {
                return _olor;
            }

            set
            {
                _olor = value;
            }
        }

        public string Sabor
        {
            get
            {
                return _sabor;
            }

            set
            {
                _sabor = value;
            }
        }

        public string Etiqueta
        {
            get
            {
                return _etiqueta;
            }

            set
            {
                _etiqueta = value;
            }
        }

        #endregion

        #region Listas

        List<string> listaTipos = new List<string>()
        {
             "Poción", "Elixir", "Brebaje", "Vial", "Filtro", "Tónico", "Infusión", "Icor", "Zumo", "Mezcla"
        };

        List<string> listaTextura = new List<string>()
        {
            "Gruesa y lodosa", "Fina y acuosa;", "Vaporosa y burbujeante", "Babosa", "Casi sólida", "Aceitosa", "Maciza", "Fragmentaria", "Lechosa", "Casi gaseosa"
        };

        List<string> listaPoder = new List<string>()
        {
            "Normal con un leve efecto secundario", "Normal sin efecto secundario", "Normal con un fuerte efecto secundario", "Menor con un fuerte efecto secundario", "Menor con un leve efecto secundario",
            "Mayor con un fuerte efecto secundario", "Mayor con un leve efecto secundario", "Un veneno.", "Temporal aunque fuerte, el efecto pasa rápidamente.",
            "Aparentemente permanente"
        };

        List<string> listaColor = new List<string>()
        {
            "Clara, transparente", "Azul", "Verde", "Roja", "Verde pálido", "Rosa", "Azul claro", "Blanca", "Negra", "Gris oscuro", "Gris claro",
            "Amarillo", "Naranja", "Dorada", "Plateada", "Bronce", "Metálica", "Morada", "Marrón", "Rojo oscuro"
        };

        List<string> listaDetalle = new List<string>()
        {
            "Manchas de color", "Remolinos de color", "Burbujas ruidosas", "Burbujas suspendidas", "Algún tipo de hueso flotando…", "Hojas y flores flotando", "Dos líquidos diferenciables",
            "Un brillo resplandeciente", "Un brillo suave", "Rayas de color;", "Traslucidez", "Un aspecto turbio", "Sangre", "Tierra flotando.", "Pedazos de metal", "¿Los pequeños restos de una criatura?",
            "Vapor emanando", "Un rostro reflejado en el líquido", "Un líquido en constante cambio y movimiento", "Un calor constante."
            };

        #endregion

        // Constructores
        public Pocion()
        {
            this.Tipo = listaTipos[new Random().Next(0, listaTipos.Count)].ToString();
            this.Poder = listaPoder[new Random().Next(0, listaPoder.Count)].ToString();
            this.EfectoPrim = GestionFichero.efectoPrim[new Random().Next(0, GestionFichero.efectoPrim.Length)].ToString();
            this.EfectoSec = GestionFichero.efectoSec[new Random().Next(0, GestionFichero.efectoSec.Length)].ToString();
            this.Color = listaColor[new Random().Next(0, listaColor.Count)].ToString();
            this.Detalle = listaDetalle[new Random().Next(0, listaDetalle.Count)].ToString();
            this.Textura = listaTextura[new Random().Next(0, listaTextura.Count)].ToString();
        }
    }
}
