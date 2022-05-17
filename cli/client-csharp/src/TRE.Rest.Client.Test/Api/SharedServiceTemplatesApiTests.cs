/*
 * Azure TRE API
 *
 * Welcome to the Azure TRE API - for more information about templates and workspaces see the [Azure TRE documentation](https://microsoft.github.io/AzureTRE)
 *
 * The version of the OpenAPI document: 0.2.14
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using TRE.Rest.Client.Client;
using TRE.Rest.Client.Api;
// uncomment below to import models
//using TRE.Rest.Client.Model;

namespace TRE.Rest.Client.Test.Api
{
    /// <summary>
    ///  Class for testing SharedServiceTemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SharedServiceTemplatesApiTests : IDisposable
    {
        private SharedServiceTemplatesApi instance;

        public SharedServiceTemplatesApiTests()
        {
            instance = new SharedServiceTemplatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SharedServiceTemplatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SharedServiceTemplatesApi
            //Assert.IsType<SharedServiceTemplatesApi>(instance);
        }

        /// <summary>
        /// Test GetSharedServiceTemplateByNameApiSharedServiceTemplatesSharedServiceTemplateNameGet
        /// </summary>
        [Fact]
        public void GetSharedServiceTemplateByNameApiSharedServiceTemplatesSharedServiceTemplateNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sharedServiceTemplateName = null;
            //var response = instance.GetSharedServiceTemplateByNameApiSharedServiceTemplatesSharedServiceTemplateNameGet(sharedServiceTemplateName);
            //Assert.IsType<SharedServiceTemplateInResponse>(response);
        }

        /// <summary>
        /// Test GetSharedServiceTemplatesApiSharedServiceTemplatesGet
        /// </summary>
        [Fact]
        public void GetSharedServiceTemplatesApiSharedServiceTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSharedServiceTemplatesApiSharedServiceTemplatesGet();
            //Assert.IsType<ResourceTemplateInformationInList>(response);
        }

        /// <summary>
        /// Test RegisterSharedServiceTemplateApiSharedServiceTemplatesPost
        /// </summary>
        [Fact]
        public void RegisterSharedServiceTemplateApiSharedServiceTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SharedServiceTemplateInCreate sharedServiceTemplateInCreate = null;
            //var response = instance.RegisterSharedServiceTemplateApiSharedServiceTemplatesPost(sharedServiceTemplateInCreate);
            //Assert.IsType<SharedServiceTemplateInResponse>(response);
        }
    }
}