using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDao
{
    public static class MateriaDao
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static SqlDataReader reader;
        static MateriaDao()
        {
            connectionString = ConnectionString.String;
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        #region LISTAR MATERIAS
        public static List<string> ListarNombreMaterias()
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT NOMBRE FROM MATERIA";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region CREAR MATERIA
        public static bool CrearMateria(string nombre, Cuatrimestre cuatrimestre, string correlativa)
        {
            bool rtn = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@cuatrimestre", (int)cuatrimestre);
                
                if(correlativa is not null)
                {
                    command.Parameters.AddWithValue("@correlativa", correlativa);
                    command.CommandText = "INSERT INTO MATERIA VALUES(@nombre, @cuatrimestre, @correlativa)";
                }
                else
                {
                    command.CommandText = "INSERT INTO MATERIA VALUES(@nombre, @cuatrimestre, null)";
                }

                int sePudoCrear = command.ExecuteNonQuery();

                if (sePudoCrear == 0)
                {
                    rtn = false;
                }
                else
                {
                    rtn = true;
                }

            }
            catch (Exception)
            {
                rtn = false;
            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return rtn;
        }

        #endregion

        #region LISTAR PROFESORES DE UNA MATERIA
        public static List<string> ListarProfesoresDeUnaMateria(string nombre)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandText = "SELECT DNI FROM MATERIAS_DEL_PROFESOR WHERE NOMBRE_MATERIA = @nombre";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region LISTAR ALUMNOS DE UNA MATERIA
        public static List<string> ListarAlumnosDeUnaMateria(string nombre)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandText = "SELECT DNI FROM MATERIAS_DEL_ALUMNO WHERE NOMBRE_MATERIA = @nombre AND ESTA_CURSANDO = 1";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion  

        #region LISTAR PROFESORES QUE NO DAN UNA MATERIA
        public static List<string> ListarProfesoresQueNoDanLaMateria(string nombre)
        {
            List<string> ret = new List<string>();
            List<string> profesoresActuales = MateriaDao.ListarProfesoresDeUnaMateria(nombre);
            try
            {
                connection.Open();
                command.CommandText = "SELECT DNI FROM USUARIO WHERE ID_TIPO = 1";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!profesoresActuales.Contains(reader[0].ToString()))
                    {
                        ret.Add(reader[0].ToString());
                    }           
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region CREAR INSTANCIA DE EXAMEN

        //parcial = 1 = primer parcial
        //parcial = 2 = segundo parcial
        public static bool CrearInstanciaDeExamen(int dni, string nombre, int parcial)
        {
            bool rtn = false;

            if(parcial == 1 || parcial == 2)
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    if(parcial == 1)
                    {
                        command.CommandText = "UPDATE MATERIAS_DEL_PROFESOR SET TOMAR_PRIMER_PARCIAL = 1 WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";

                    }
                    else
                    {
                        command.CommandText = "UPDATE MATERIAS_DEL_PROFESOR SET TOMAR_SEGUNDO_PARCIAL = 1 WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";
                    }

                    int ejecucion = command.ExecuteNonQuery();

                    if (ejecucion == 1)
                    {
                        rtn = true;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                    command.Parameters.Clear();
                }
            }
            return rtn;
        }

        #endregion

        #region ELIMINAR PROFESOR DE MATERIA
        public static bool EliminarProfesorDeUnaMateria(int dni, string nombre)
        {
            bool rtn = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandText = "DELETE FROM MATERIAS_DEL_PROFESOR WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";


                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rtn = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return rtn;
        }

        #endregion

        #region AGREGAR PROFESOR A UNA MATERIA
        public static bool AgregarProfesorAUnaMateria(int dni, string nombre)
        {
            bool rtn = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombre);

                command.CommandText = "SELECT * FROM MATERIAS_DEL_PROFESOR WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";

                reader = command.ExecuteReader();

                int filasAfectadas = 0;

                if (!reader.HasRows)
                {
                    reader.Close();
                    command.CommandText = "INSERT INTO MATERIAS_DEL_PROFESOR VALUES (@dni, @nombre, 0, 0)";
                    filasAfectadas = command.ExecuteNonQuery();
                }
                
                if (filasAfectadas == 0)
                {
                    rtn = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return rtn;
        }

        #endregion

        #region AGREGAR ALUMNO A UNA MATERIA
        public static bool AgregarAlumnoAUnaMateria(int dni, string nombre)
        {
            bool rtn = false;
            string aux = null;
            bool empezar = true;

            foreach(var materia in MateriaDao.ListarMateriasActualesDeUnAlumno(dni))
            {
                if(materia == nombre)
                {
                    empezar = false;
                    break;
                }
            }

            List<string> materiasAprobadas = MateriaDao.ListarMateriasAprobadasDeUnAlumno(dni);

            foreach (var materia in materiasAprobadas)
            {
                if (materia == nombre)
                {
                    empezar = false;
                    break;
                }
            }

            if (empezar)
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    command.CommandText = "SELECT CORRELATIVA FROM MATERIA WHERE NOMBRE = @nombre";
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        aux = reader[0].ToString();

                        if (aux is not null && aux != "")
                        {
                            foreach (var materia in materiasAprobadas)
                            {
                                if (materia == aux)
                                {
                                    rtn = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            rtn = true;
                        }
                    }

                    if (rtn == true)
                    {
                        command.CommandText = "INSERT INTO MATERIAS_DEL_ALUMNO VALUES(@dni,@nombre,-1,-1, 1, 1)";
                        reader.Close();
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            rtn = false;
                        }
                    }

                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                    command.Parameters.Clear();
                }
            }
            
            return rtn;
        }

        #endregion

        #region LISTAR MATERIAS ACTUALES DE UN ALUMNO
        public static List<string> ListarMateriasActualesDeUnAlumno(int dni)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "SELECT NOMBRE_MATERIA FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND ESTA_CURSANDO = 1";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region LISTAR PROFESORES DE UNA MATERIA
        public static List<string> ListarMateriasActualesDeUnProfesor(int dni)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "SELECT NOMBRE_MATERIA FROM MATERIAS_DEL_PROFESOR WHERE DNI = @dni";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region LISTAR MATERIAS APROBADAS DE UN ALUMNO

        public static List<string> ListarMateriasAprobadasDeUnAlumno(int dni)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "SELECT NOMBRE_MATERIA FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND ESTA_CURSANDO = 0";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region OBTENER ESTADO MATERIA DE UN ALUMNO

        public static EstadoMateria ObtenerEstadoMateriaDeUnAlumno(int dni, string nombre)
        {
            EstadoMateria estadoMateria = EstadoMateria.Regular;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandText = "SELECT ESTADO_MATERIA FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    estadoMateria = (EstadoMateria)int.Parse(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return estadoMateria;
        }

        #endregion

        #region CAMBIAR ESTADO MATERIA DE UN ALUMNO
        public static bool CambiarEstadoMateriaAlumno(int dni, string nombre, EstadoMateria estadoMateria)
        {
            bool rtn = true;
           
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@estadoMateria", (int)estadoMateria);
                command.CommandText = "UPDATE MATERIAS_DEL_ALUMNO SET ESTADO_MATERIA = @estadoMateria WHERE DNI = @dni AND NOMBRE_MATERIA = @nombre";
                
                int ejecucion = command.ExecuteNonQuery();
                
                if(ejecucion == 0)
                {
                    rtn = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return rtn;
        }

        #endregion

        #region LISTAR INSTANCIAS DE EXAMEN
        public static List<string> ListarInstanciasDeUnProfesor(int dni, string materia)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "SELECT TOMAR_PRIMER_PARCIAL,TOMAR_SEGUNDO_PARCIAL FROM MATERIAS_DEL_PROFESOR WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string primerParcial = reader[0].ToString();
                    string segundoParcial = reader[1].ToString();

                    if(primerParcial == "True")
                    {
                        ret.Add("Primer parcial");
                    }
                    if(segundoParcial == "True")
                    {
                        ret.Add("Segundo parcial");
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region CONSULTAR NOTAS
        public static int NotaDeUnAlumno(int dni, string materia, string instancia)
        {
            int ret = -1;
            bool flag = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@dni", dni);
                
                if(instancia == "Primer parcial")
                {
                    command.CommandText = "SELECT NOTA_PRIMER_PARCIAL FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                    flag = true;

                }
                if (instancia == "Segundo parcial")
                {
                    command.CommandText = "SELECT NOTA_SEGUNDO_PARCIAL FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                    flag = true;
                }

                if (flag)
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ret = int.Parse(reader[0].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region PONER NOTA
        public static bool PonerNotaAlumno(int dni, string materia, string instancia, int nota)
        {
            bool ret = false;
            int flag = 0;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nota", nota);

                if (instancia == "Primer parcial")
                {
                    command.CommandText = "UPDATE MATERIAS_DEL_ALUMNO SET NOTA_PRIMER_PARCIAL = @nota WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                    flag = 1;

                }
                if (instancia == "Segundo parcial")
                {
                    command.CommandText = "UPDATE MATERIAS_DEL_ALUMNO SET NOTA_SEGUNDO_PARCIAL = @nota WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                    flag = 1;
                }

                if(flag == 1)
                {
                    int filasAfectadas = command.ExecuteNonQuery();

                    if(filasAfectadas == 1)
                    {
                        ret = true;
                    }
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return ret;
        }

        #endregion

        #region VERIFICAR SI ALUMNO APROBO

        public static bool VerificarSiAprobo(int dni, string materia)
        {
            bool rtn = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@dni", dni);

                command.CommandText = "SELECT NOTA_PRIMER_PARCIAL, NOTA_SEGUNDO_PARCIAL, ESTADO_MATERIA FROM MATERIAS_DEL_ALUMNO WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int primerNota = int.Parse(reader[0].ToString());
                    int segundaNota = int.Parse(reader[1].ToString());
                    int estadoMateria = int.Parse(reader[2].ToString());

                    if (primerNota >= 6 && segundaNota >= 6 && estadoMateria == 1)
                    {
                        rtn = true;
                    }
                }

                if(rtn == true)
                {
                    reader.Close();
                    command.CommandText = "UPDATE MATERIAS_DEL_ALUMNO SET ESTA_CURSANDO = 0 WHERE DNI = @dni AND NOMBRE_MATERIA = @materia";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return rtn;
        }

        #endregion
    }
}
