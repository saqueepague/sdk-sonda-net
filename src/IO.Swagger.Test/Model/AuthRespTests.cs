/* 
 * Saque e Pague Sonda
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.1-sw2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AuthResp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AuthRespTests
    {
        // TODO uncomment below to declare an instance variable for AuthResp
        //private AuthResp instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AuthResp
            //instance = new AuthResp();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthResp
        /// </summary>
        [Test]
        public void AuthRespInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AuthResp
            //Assert.IsInstanceOfType<AuthResp> (instance, "variable 'instance' is a AuthResp");
        }


        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Test]
        public void AccessTokenTest()
        {
            // TODO unit test for the property 'AccessToken'
        }
        /// <summary>
        /// Test the property 'ExpiresIn'
        /// </summary>
        [Test]
        public void ExpiresInTest()
        {
            // TODO unit test for the property 'ExpiresIn'
        }
        /// <summary>
        /// Test the property 'TokenType'
        /// </summary>
        [Test]
        public void TokenTypeTest()
        {
            // TODO unit test for the property 'TokenType'
        }

    }

}
