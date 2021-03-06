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
pub struct Pin {
    /// Libp2p peer ID of the node pinning the data.
    #[serde(rename = "peerId", skip_serializing_if = "Option::is_none")]
    pub peer_id: Option<String>,
    /// Human readable name for the peer pinning the data.
    #[serde(rename = "peerName", skip_serializing_if = "Option::is_none")]
    pub peer_name: Option<String>,
    /// Approximate geographical region of the node pinning the data.
    #[serde(rename = "region", skip_serializing_if = "Option::is_none")]
    pub region: Option<String>,
    #[serde(rename = "status", skip_serializing_if = "Option::is_none")]
    pub status: Option<Status>,
    /// This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ.
    #[serde(rename = "updated", skip_serializing_if = "Option::is_none")]
    pub updated: Option<String>,
}

impl Pin {
    pub fn new() -> Pin {
        Pin {
            peer_id: None,
            peer_name: None,
            region: None,
            status: None,
            updated: None,
        }
    }
}

/// 
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum Status {
    #[serde(rename = "PinQueued")]
    PinQueued,
    #[serde(rename = "Pinning")]
    Pinning,
    #[serde(rename = "Pinned")]
    Pinned,
}

