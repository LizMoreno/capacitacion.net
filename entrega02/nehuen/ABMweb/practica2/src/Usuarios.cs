using System;


namespace practica2.src
{
    public class Usuarios
    {
        public int idUsuario
        {
            get;
            set;
        }
        public String email
        {
            get;
            set;
        }
        public String usuario
        {
            get;
            set;
        }

        public String password
        {
            get;
            set;
        }

        public Usuarios()
        { }

        public Usuarios(int idUsuario,  String usuario, String email, String password)
        {
            this.idUsuario = idUsuario;
            this.email = email;
            this.usuario = usuario;
            this.password = password;
        }
        public String nombre()
        {
            var n = this.idUsuario + " " + this.email;
            return n;
        }





    }
}