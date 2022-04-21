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
    /// UploadResponse
    /// </summary>
    [DataContract(Name = "UploadResponse")]
    public partial class UploadResponse : IEquatable<UploadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        /// <param name="cid">Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info..</param>
        public UploadResponse(string cid = default(string))
        {
            this.Cid = cid;
        }

        /// <summary>
        /// Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info.
        /// </summary>
        /// <value>Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info.</value>
        [DataMember(Name = "cid", EmitDefaultValue = false)]
        public string Cid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadResponse {\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadResponse);
        }

        /// <summary>
        /// Returns true if UploadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cid == input.Cid ||
                    (this.Cid != null &&
                    this.Cid.Equals(input.Cid))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cid != null)
                    hashCode = hashCode * 59 + this.Cid.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}