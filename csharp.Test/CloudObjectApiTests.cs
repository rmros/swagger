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
    ///  Class for testing CloudObjectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CloudObjectApiTests
    {
        private CloudObjectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new CloudObjectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CloudObjectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<CloudObjectApi> (instance, "instance is a CloudObjectApi");
        }

        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO: add unit test for the method 'Delete'
            string appId = null; // TODO: replace null with proper value
            string tableName = null; // TODO: replace null with proper value
            CloudObjectSaveRequest body = null; // TODO: replace null with proper value
            
            var response = instance.Delete(appId, tableName, body);
            Assert.IsInstanceOf<CloudObject> (response, "response is CloudObject"); 
        }
        
        /// <summary>
        /// Test Save
        /// </summary>
        [Test]
        public void SaveTest()
        {
            // TODO: add unit test for the method 'Save'
            string appId = null; // TODO: replace null with proper value
            string tableName = null; // TODO: replace null with proper value
            CloudObjectSaveRequest body = null; // TODO: replace null with proper value
            
            var response = instance.Save(appId, tableName, body);
            Assert.IsInstanceOf<CloudObject> (response, "response is CloudObject"); 
        }
        
    }

}
