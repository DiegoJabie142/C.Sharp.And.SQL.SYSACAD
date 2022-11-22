using System.Dynamic;

namespace Entidades
{
    public abstract class Usuario
    {
        protected int dni; // CLAVE PRIMARIA
        protected string nombre;
        protected string apellido;
        protected string contraseña;
        protected TipoUsuario idTipo;

        #region CONSTRUCTOR     
        public Usuario(int dni, string nombre, string apellido, string contraseña, TipoUsuario idTipo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.idTipo = idTipo;
        }

        public abstract int DNI
        {
            get;
        }

        public abstract string Nombre {
            get;
        }

        public abstract string Apellido
        {
            get;
        }

        public abstract string Contraseña
        {
            get;
        }
        public abstract TipoUsuario IdTipo
        {
            get;
        }


        #endregion
    }
}
