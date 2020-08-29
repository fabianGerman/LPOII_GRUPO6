using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {

        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Password;
        private string usu_ApellidoNombre;
        private string rol_Codigo;

        public Usuario(int id, string us, string pass, string name, string rol) 
        {
            this.usu_ID = id;
            this.usu_NombreUsuario = us;
            this.usu_Password = pass;
            this.usu_ApellidoNombre = name;
            this.rol_Codigo = rol;
        }

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        

        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        

        public string Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }
    }
}
