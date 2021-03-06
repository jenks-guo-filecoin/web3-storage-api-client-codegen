/*
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits. 
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Web3.Storage.Api;
using Web3.Storage.Model;
using Web3.Storage.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Web3.Storage.Test.Model
{
    /// <summary>
    ///  Class for testing UnauthorizedErrorResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UnauthorizedErrorResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UnauthorizedErrorResponse
        //private UnauthorizedErrorResponse instance;

        public UnauthorizedErrorResponseTests()
        {
            // TODO uncomment below to create an instance of UnauthorizedErrorResponse
            //instance = new UnauthorizedErrorResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UnauthorizedErrorResponse
        /// </summary>
        [Fact]
        public void UnauthorizedErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" UnauthorizedErrorResponse
            //Assert.IsType<UnauthorizedErrorResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

    }

}
