using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaMVC.Controllers;
using PracticaMVC.Metodos;
using PracticaMVC.Models;

namespace UnitTestPracticaMVC1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ListarClienteXProfesion()
        {
            ClienteB listar = new ClienteB();
            int idCliente = 1;
            List<ClienteEntity> lst = listar.ListarClienteXProfesion(idCliente);
        }
    }
}
