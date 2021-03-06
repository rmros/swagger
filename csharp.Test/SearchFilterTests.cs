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
    ///  Class for testing SearchFilter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SearchFilterTests
    {
        private SearchFilter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchFilter();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SearchFilter
        /// </summary>
        [Test]
        public void SearchFilterInstanceTest()
        {
            Assert.IsInstanceOf<SearchFilter> (instance, "instance is a SearchFilter");
        }

        
        /// <summary>
        /// Test the property 'MustNot' 
        /// </summary>
        [Test]
        public void MustNotTest()
        {
            // TODO: unit test for the property 'MustNot' 
        }
        
        /// <summary>
        /// Test the property 'Should' 
        /// </summary>
        [Test]
        public void ShouldTest()
        {
            // TODO: unit test for the property 'Should' 
        }
        
        /// <summary>
        /// Test the property 'Must' 
        /// </summary>
        [Test]
        public void MustTest()
        {
            // TODO: unit test for the property 'Must' 
        }
        

    }

}
