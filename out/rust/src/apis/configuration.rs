/*
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits. 
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */


use reqwest;

#[derive(Debug, Clone)]
pub struct Configuration {
    pub base_path: String,
    pub user_agent: Option<String>,
    pub client: reqwest::Client,
    pub basic_auth: Option<BasicAuth>,
    pub oauth_access_token: Option<String>,
    pub bearer_access_token: Option<String>,
    pub api_key: Option<ApiKey>,
    // TODO: take an oauth2 token source, similar to the go one
}

pub type BasicAuth = (String, Option<String>);

#[derive(Debug, Clone)]
pub struct ApiKey {
    pub prefix: Option<String>,
    pub key: String,
}

impl Configuration {
    pub fn new() -> Configuration {
        Configuration::default()
    }
}

impl Default for Configuration {
    fn default() -> Self {
        Configuration {
            base_path: "https://api.web3.storage".to_owned(),
            user_agent: Some("OpenAPI-Generator/1.0/rust".to_owned()),
            client: reqwest::Client::new(),
            basic_auth: None,
            oauth_access_token: None,
            bearer_access_token: None,
            api_key: None,
        }
    }
}