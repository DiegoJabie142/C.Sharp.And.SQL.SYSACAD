using System;
using EntidadesDao;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;

namespace Probando
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string diego = UsuarioDao.ListarNombrePorDni(42598324);

            Console.WriteLine(diego);
        }
    }
}
