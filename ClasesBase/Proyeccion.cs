using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private int proy_Codigo;

        public int Proy_Codigo
        {
            get { return proy_Codigo; }
            set { proy_Codigo = value; }
        }
        private string proy_Fecha;

        public string Proy_Fecha
        {
            get { return proy_Fecha; }
            set { proy_Fecha = value; }
        }
        private string proy_Hora;

        public string Proy_Hora
        {
            get { return proy_Hora; }
            set { proy_Hora = value; }
        }
        private string proy_NroSala;

        public string Proy_NroSala
        {
            get { return proy_NroSala; }
            set { proy_NroSala = value; }
        }
    }
}
