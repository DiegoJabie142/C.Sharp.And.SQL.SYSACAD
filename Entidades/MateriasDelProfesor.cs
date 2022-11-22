namespace Entidades
{
    public class MateriasDelProfesor
    {
        private string dni;
        private string nombreMateria;
        private bool tomarPrimerParcial;
        private bool tomarSegundoParcial;


        #region CONSTRUCTORES
        public MateriasDelProfesor(string dni, string nombreMateria)
        {
            this.dni = dni;
            this.nombreMateria = nombreMateria;
            this.tomarPrimerParcial = false;
            this.tomarSegundoParcial = false;
        }

        public MateriasDelProfesor(string dni, string nombreMateria, bool tomarPrimerParcial, bool tomarSegundoParcial) : this(dni, nombreMateria)
        {
            this.tomarPrimerParcial = tomarPrimerParcial;
            this.tomarSegundoParcial = tomarSegundoParcial;
        }

        #endregion
    }
}
