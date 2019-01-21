/* 
 * Saque e Pague Sonda
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.1-sw2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AuthControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthControllerApiTests
    {
        private AuthControllerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthControllerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthControllerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthControllerApi
            //Assert.IsInstanceOfType(typeof(AuthControllerApi), instance, "instance is a AuthControllerApi");
        }

        
        /// <summary>
        /// Test SaqueepagueOauthTokenPost
        /// </summary>
        [Test]
        public void SaqueepagueOauthTokenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string grantType = null;
            //string password = null;
            //string username = null;
            //var response = instance.SaqueepagueOauthTokenPost(grantType, password, username);
            //Assert.IsInstanceOf<AuthResp> (response, "response is AuthResp");
        }
        
    }

}
