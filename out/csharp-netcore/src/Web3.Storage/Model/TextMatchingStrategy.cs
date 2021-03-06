/*
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits. 
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Web3.Storage.Client.OpenAPIDateConverter;

namespace Web3.Storage.Model
{
    /// <summary>
    /// Alternative text matching strategy
    /// </summary>
    /// <value>Alternative text matching strategy</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextMatchingStrategy
    {
        /// <summary>
        /// Enum Exact for value: exact
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact = 1,

        /// <summary>
        /// Enum Iexact for value: iexact
        /// </summary>
        [EnumMember(Value = "iexact")]
        Iexact = 2,

        /// <summary>
        /// Enum Partial for value: partial
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial = 3,

        /// <summary>
        /// Enum Ipartial for value: ipartial
        /// </summary>
        [EnumMember(Value = "ipartial")]
        Ipartial = 4

    }

}
