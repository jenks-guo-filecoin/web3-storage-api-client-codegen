/*
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits. 
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Status {
    /// Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info.
    #[serde(rename = "cid", skip_serializing_if = "Option::is_none")]
    pub cid: Option<String>,
    /// Total size of the DAG in bytes.
    #[serde(rename = "dagSize", skip_serializing_if = "Option::is_none")]
    pub dag_size: Option<f32>,
    /// This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ.
    #[serde(rename = "created", skip_serializing_if = "Option::is_none")]
    pub created: Option<String>,
    #[serde(rename = "pins", skip_serializing_if = "Option::is_none")]
    pub pins: Option<Vec<crate::models::Pin>>,
    #[serde(rename = "deals", skip_serializing_if = "Option::is_none")]
    pub deals: Option<Vec<crate::models::Deal>>,
}

impl Status {
    pub fn new() -> Status {
        Status {
            cid: None,
            dag_size: None,
            created: None,
            pins: None,
            deals: None,
        }
    }
}


