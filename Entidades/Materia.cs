namespace Entidades
{
    public class Materia
    {
        private string nombre;
        private Cuatrimestre cuatrimestre;
        private string correlativa;

        //CONSTRUCTOR SIN CORRELATIVA
        public Materia(string nombre, Cuatrimestre cuatrimestre)
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.correlativa = null;
        }

        //CONSTRUCTOR CON CORRELATIVA
        public Materia(string nombre, Cuatrimestre cuatrimestre, string correlativa) : this(nombre, cuatrimestre)
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.correlativa = correlativa;
        }


    }
}
