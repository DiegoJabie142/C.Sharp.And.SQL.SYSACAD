namespace Entidades
{
    public class MateriasDelAlumno
    {
        private string dni;
        private string nombreMateria;
        private int notaPrimerParcial; // -1 = no inasignada
        private int notaSegundoParcial; // -1 = no asignada
        private EstadoMateria estadoMateria;
        private bool estaCursando;

        #region CONSTRUCTOR

        //Constructor sin notas
        public MateriasDelAlumno(string dni, string nombreMateria)
        {
            this.dni = dni;
            this.nombreMateria = nombreMateria;
            this.notaPrimerParcial = -1;
            this.notaSegundoParcial = -1;
            this.estadoMateria = EstadoMateria.Regular;
            this.estaCursando = true;
        }

        //Constructor con notas
        public MateriasDelAlumno(string dni, string nombreMateria, int notaPrimerParcial, int notaSegundoParcial, EstadoMateria estadoMateria, bool estaCursando) : this(dni, nombreMateria)
        {
            this.dni = dni;
            this.nombreMateria = nombreMateria;
            this.notaPrimerParcial = notaPrimerParcial;
            this.notaSegundoParcial = notaSegundoParcial;
            this.estadoMateria = estadoMateria;
            this.estaCursando = estaCursando;
        }

        #endregion

        #region PROPIEDADES

        public EstadoMateria EstadoMateria
        {
            get { return this.estadoMateria; }
            set { this.EstadoMateria = value; }
        }

        public bool EstaCursando
        {
            get { return this.estaCursando; }
            set { this.estaCursando = value; }
        }

        public int NotaPrimerParcial
        {
            get { return this.NotaPrimerParcial; }
            set { this.notaPrimerParcial = value; }
        }

        public int NotaSegundoParcial
        {
            get { return this.notaSegundoParcial; }
            set { this.notaSegundoParcial = value; }
        }

        #endregion
    }
}
