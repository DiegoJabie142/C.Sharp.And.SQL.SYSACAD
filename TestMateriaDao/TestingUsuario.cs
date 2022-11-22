using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using EntidadesDao;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMateriaDao
{
    [TestClass]
    public class TestingUsuario
    {
        [TestMethod]
        public void TestCrearUsuario()
        {
            bool rta = false;

            rta = UsuarioDao.CrearUsuario(42322322, "Pedro", "Bogado", "12345678", 2); // creo un alumno

            Assert.IsTrue(rta);
        }


        [TestMethod]
        public void TestListarDniPorTipo()
        {
            bool rta = false;

            UsuarioDao.CrearUsuario(42322322, "Pedro", "Bogado", "12345678", 2); // creo un alumno

            List<string> dnis = UsuarioDao.ListarDniPorTipo(TipoUsuario.Alumno);

            foreach(var item in dnis)
            {
                if(item.Equals("42322322"))
                {
                    rta = true;
                    break;
                }
            }

            UsuarioDao.BorrarUsuario(42322322);

            Assert.IsTrue(rta);
        }

        [TestMethod]

        public void TestEliminarUsuario()
        {
            bool rta = false;

            UsuarioDao.CrearUsuario(42322322, "Pedro", "Bogado", "12345678", 2);
            rta = UsuarioDao.BorrarUsuario(42322322); // elimino el usuario anteriormente creado;

            Assert.IsTrue(rta);
        }

    }
}
