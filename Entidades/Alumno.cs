namespace Entidades
{
    public class Alumno : Usuario
    {

        #region CONSTRUCTOR
        public Alumno()
        {

        }

        public Alumno(int dni, string nombre, string apellido, string contraseña) : base(dni, nombre, apellido, contraseña, TipoUsuario.Alumno)
        {
        }

        #endregion

        public override int DNI { get { return this.dni; } }

        public override string Nombre { get { return this.nombre; } }

        public override string Apellido { get { return this.apellido; } }

        public override string Contraseña { get { return this.contraseña; } }

        public override TipoUsuario IdTipo { get { return this.idTipo; } }

    }
}
