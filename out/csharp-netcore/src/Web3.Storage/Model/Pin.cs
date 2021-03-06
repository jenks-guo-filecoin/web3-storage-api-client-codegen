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
    /// Pin
    /// </summary>
    [DataContract(Name = "Pin")]
    public partial class Pin : IEquatable<Pin>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum PinQueued for value: PinQueued
            /// </summary>
            [EnumMember(Value = "PinQueued")]
            PinQueued = 1,

            /// <summary>
            /// Enum Pinning for value: Pinning
            /// </summary>
            [EnumMember(Value = "Pinning")]
            Pinning = 2,

            /// <summary>
            /// Enum Pinned for value: Pinned
            /// </summary>
            [EnumMember(Value = "Pinned")]
            Pinned = 3

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pin" /> class.
        /// </summary>
        /// <param name="peerId">Libp2p peer ID of the node pinning the data..</param>
        /// <param name="peerName">Human readable name for the peer pinning the data..</param>
        /// <param name="region">Approximate geographical region of the node pinning the data..</param>
        /// <param name="status">status.</param>
        /// <param name="updated">This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ..</param>
        public Pin(string peerId = default(string), string peerName = default(string), string region = default(string), StatusEnum? status = default(StatusEnum?), DateTime updated = default(DateTime))
        {
            this.PeerId = peerId;
            this.PeerName = peerName;
            this.Region = region;
            this.Status = status;
            this.Updated = updated;
        }

        /// <summary>
        /// Libp2p peer ID of the node pinning the data.
        /// </summary>
        /// <value>Libp2p peer ID of the node pinning the data.</value>
        [DataMember(Name = "peerId", EmitDefaultValue = false)]
        public string PeerId { get; set; }

        /// <summary>
        /// Human readable name for the peer pinning the data.
        /// </summary>
        /// <value>Human readable name for the peer pinning the data.</value>
        [DataMember(Name = "peerName", EmitDefaultValue = false)]
        public string PeerName { get; set; }

        /// <summary>
        /// Approximate geographical region of the node pinning the data.
        /// </summary>
        /// <value>Approximate geographical region of the node pinning the data.</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        /// <value>This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ.</value>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pin {\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  PeerName: ").Append(PeerName).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as Pin);
        }

        /// <summary>
        /// Returns true if Pin instances are equal
        /// </summary>
        /// <param name="input">Instance of Pin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeerId == input.PeerId ||
                    (this.PeerId != null &&
                    this.PeerId.Equals(input.PeerId))
                ) && 
                (
                    this.PeerName == input.PeerName ||
                    (this.PeerName != null &&
                    this.PeerName.Equals(input.PeerName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.PeerId != null)
                    hashCode = hashCode * 59 + this.PeerId.GetHashCode();
                if (this.PeerName != null)
                    hashCode = hashCode * 59 + this.PeerName.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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
