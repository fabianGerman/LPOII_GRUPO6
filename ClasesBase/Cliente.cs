using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private int cli_DNI;
        private string cli_Nombre;
        private string cli_Apellido;
        private string cli_Telefono;
        private string cli_Email;

        public Cliente(){}

        public Cliente(int dni, string nombre, string apellido, string telefono, string email)
        {
            this.cli_DNI = dni;
            this.cli_Nombre = nombre;
            this.cli_Apellido = apellido;
            this.cli_Telefono = telefono;
            this.cli_Email = email;
        }

        public int Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }


        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }

        public string Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }
    }
}
