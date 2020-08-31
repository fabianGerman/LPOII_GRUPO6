using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        public Pelicula()
        {
        }

        public Pelicula(string codigo, string titulo, string duracion, string genero, string clase)
        {
            this.peli_Clase = clase;
            this.peli_Codigo = codigo;
            this.peli_Duracion = duracion;
            this.peli_Genero = genero;
            this.peli_Titulo = titulo;
        }

        private string peli_Codigo;

        private string peli_Titulo;

        private string peli_Duracion;

        private string peli_Genero;

        private string peli_Clase;


        public string Peli_Titulo
        {
            get { return peli_Titulo; }
            set { peli_Titulo = value; }
        }

        public string Peli_Duracion
        {
            get { return peli_Duracion; }
            set { peli_Duracion = value; }
        }
        public string Peli_Genero
        {
            get { return peli_Genero; }
            set { peli_Genero = value; }
        }

        public string Peli_Codigo
        {
            get { return peli_Codigo; }
            set { peli_Codigo = value; }
        }
        public string Peli_Clase
        {
            get { return peli_Clase; }
            set { peli_Clase = value; }
        }

       
    }
}
