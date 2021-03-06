using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CloudObjectSaveRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CloudObjectSaveRequestTests
    {
        private CloudObjectSaveRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CloudObjectSaveRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CloudObjectSaveRequest
        /// </summary>
        [Test]
        public void CloudObjectSaveRequestInstanceTest()
        {
            Assert.IsInstanceOf<CloudObjectSaveRequest> (instance, "instance is a CloudObjectSaveRequest");
        }

        
        /// <summary>
        /// Test the property 'Key' 
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO: unit test for the property 'Key' 
        }
        
        /// <summary>
        /// Test the property 'Document' 
        /// </summary>
        [Test]
        public void DocumentTest()
        {
            // TODO: unit test for the property 'Document' 
        }
        

    }

}
