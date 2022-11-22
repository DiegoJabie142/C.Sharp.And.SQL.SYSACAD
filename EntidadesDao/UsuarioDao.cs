using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Entidades;

namespace EntidadesDao
{
    public static class UsuarioDao
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static SqlDataReader reader;
        static UsuarioDao()
        {
            connectionString = ConnectionString.String;
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        #region PROBAR CONEXIÓN

        public static bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return rta;
        }

        #endregion

        #region LOGIN DE USUARIO

        public static Usuario Login(int dni, string contraseña)
        {
            Usuario user = null;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@contraseña", contraseña);
                command.CommandText = "SELECT * FROM USUARIO WHERE DNI = @dni AND CONTRASEÑA = @contraseña";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((int)reader["ID_TIPO"] == 0)
                    {
                        user = new Administrador((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    }else if((int)reader["ID_TIPO"] == 1)
                    {
                        user = new Profesor((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    }
                    else if((int)reader["ID_TIPO"] == 2)
                    {
                        user = new Alumno((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    }
                }

            }catch(Exception)
            {
                user = null;
            }
            finally
            {
                connection.Close();
                command.Parameters.Clear();
            }

            return user;
        }

        #endregion

        #region CREAR USUARIO

        public static bool CrearUsuario(int dni, string nombre, string apellido, string contraseña, int idTipo)
        {
            bool rtn = false;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@contraseña", contraseña);
                command.Parameters.AddWithValue("@idTipo", idTipo);
                command.CommandText = "INSERT INTO USUARIO VALUES(@dni, @nombre, @apellido, @contraseña, @idTipo)";

                int sePudoCrear = command.ExecuteNonQuery();

                if(sePudoCrear == 0)
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

        #region BORRAR USUARIO
        public static bool BorrarUsuario(int dni)
        {
            bool rtn = true;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "DELETE FROM USUARIO WHERE DNI = @dni";
               
                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rtn = false;
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

            return rtn;
        }

        #endregion

        #region CONSULTAS

        public static List<string> ListarDniPorTipo(TipoUsuario tipoUsuario)
        {
            List<string> ret = new List<string>();

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@tipoUsuario", (int)tipoUsuario);
                command.CommandText = "SELECT DNI FROM USUARIO WHERE ID_TIPO = @tipoUsuario";
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

        #region OBTENER USUARIOS DE UNA MATERIA 

        public static List<Alumno> ListarAlumnosPorMateria(string materia)
        {
            List<Alumno> ret = new List<Alumno>();
            List<string> dnis = new List<string>();
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@materia", materia);
                command.CommandText = "SELECT DNI FROM MATERIAS_DEL_ALUMNO WHERE NOMBRE_MATERIA = @materia AND ESTA_CURSANDO = 1";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dnis.Add(reader[0].ToString());
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

            foreach (var dni in dnis)
            {
                ret.Add(UsuarioDao.CrearAlumnoPorDni(int.Parse(dni)));
            }

            return ret;
        }

        #endregion

        public static Alumno CrearAlumnoPorDni(int dni)
        {
            Alumno alumno = null;

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@dni", dni);
                command.CommandText = "SELECT * FROM USUARIO WHERE DNI = @dni";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    alumno = new Alumno(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
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

            return alumno;
        }
    }
}
