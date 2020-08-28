using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contra;
        private string p;
        private string p_2;

        public string Usu_Contra
        {
            get { return usu_Contra; }
            set { usu_Contra = value; }
        }
        public Usuario(string p, string p_2)
        {
            // TODO: Complete member initialization
            usu_NombreUsuario = p;
            usu_Contra = p_2 ;
        }
    }
}
