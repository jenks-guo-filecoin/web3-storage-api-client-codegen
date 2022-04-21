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
    /// FailureError
    /// </summary>
    [DataContract(Name = "Failure_error")]
    public partial class FailureError : IEquatable<FailureError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailureError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FailureError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FailureError" /> class.
        /// </summary>
        /// <param name="reason">Mandatory string identifying the type of error (required).</param>
        /// <param name="details">Optional, longer description of the error; may include UUID of transaction for support, links to documentation etc.</param>
        public FailureError(string reason = default(string), string details = default(string))
        {
            // to ensure "reason" is required (not null)
            this.Reason = reason ?? throw new ArgumentNullException("reason is a required property for FailureError and cannot be null");
            this.Details = details;
        }

        /// <summary>
        /// Mandatory string identifying the type of error
        /// </summary>
        /// <value>Mandatory string identifying the type of error</value>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Optional, longer description of the error; may include UUID of transaction for support, links to documentation etc
        /// </summary>
        /// <value>Optional, longer description of the error; may include UUID of transaction for support, links to documentation etc</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailureError {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as FailureError);
        }

        /// <summary>
        /// Returns true if FailureError instances are equal
        /// </summary>
        /// <param name="input">Instance of FailureError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FailureError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
