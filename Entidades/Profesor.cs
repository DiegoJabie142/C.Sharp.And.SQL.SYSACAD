namespace Entidades
{
    public class Profesor : Usuario
    {
        #region CONSTRUCTOR

        public Profesor()
        {

        }

        public Profesor(int dni, string nombre, string apellido, string contraseña) : base(dni, nombre, apellido, contraseña, TipoUsuario.Profesor)
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
