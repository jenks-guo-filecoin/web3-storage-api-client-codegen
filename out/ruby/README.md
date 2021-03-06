# web3_storage

Web3Storage - the Ruby gem for the Web3.Storage API

This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).

You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.

## API endpoint URL

The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.

### Rate limits

This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits.


This SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- Package version: 1.0.0
- Build package: org.openapitools.codegen.languages.RubyClientCodegen

## Installation

### Build a gem

To build the Ruby code into a gem:

```shell
gem build web3_storage.gemspec
```

Then either install the gem locally:

```shell
gem install ./web3_storage-1.0.0.gem
```

(for development, run `gem install --dev ./web3_storage-1.0.0.gem` to install the development dependencies)

or publish the gem to a gem hosting service, e.g. [RubyGems](https://rubygems.org/).

Finally add this to the Gemfile:

    gem 'web3_storage', '~> 1.0.0'

### Install from Git

If the Ruby gem is hosted at a git repository: https://github.com/GIT_USER_ID/GIT_REPO_ID, then add the following in the Gemfile:

    gem 'web3_storage', :git => 'https://github.com/GIT_USER_ID/GIT_REPO_ID.git'

### Include the Ruby code directly

Include the Ruby code directly using `-I` as follows:

```shell
ruby -Ilib script.rb
```

## Getting Started

Please follow the [installation](#installation) procedure and then run the following code:

```ruby
# Load the gem
require 'web3_storage'

# Setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
requestid = 'requestid_example' # String | 

begin
  #Remove pin object
  api_instance.delete_pins_requestid(requestid)
rescue Web3Storage::ApiError => e
  puts "Exception when calling Web3StorageHTTPAPIApi->delete_pins_requestid: #{e}"
end

```

## Documentation for API Endpoints

All URIs are relative to *https://api.web3.storage*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Web3Storage::Web3StorageHTTPAPIApi* | [**delete_pins_requestid**](docs/Web3StorageHTTPAPIApi.md#delete_pins_requestid) | **DELETE** /pins/{requestid} | Remove pin object
*Web3Storage::Web3StorageHTTPAPIApi* | [**get_car_cid**](docs/Web3StorageHTTPAPIApi.md#get_car_cid) | **GET** /car/{cid} | Retrieve a CAR
*Web3Storage::Web3StorageHTTPAPIApi* | [**get_pins**](docs/Web3StorageHTTPAPIApi.md#get_pins) | **GET** /pins | List pin objects
*Web3Storage::Web3StorageHTTPAPIApi* | [**get_pins_requestid**](docs/Web3StorageHTTPAPIApi.md#get_pins_requestid) | **GET** /pins/{requestid} | Get pin object
*Web3Storage::Web3StorageHTTPAPIApi* | [**get_status_cid**](docs/Web3StorageHTTPAPIApi.md#get_status_cid) | **GET** /status/{cid} | Retrieve information about an upload
*Web3Storage::Web3StorageHTTPAPIApi* | [**get_user_uploads**](docs/Web3StorageHTTPAPIApi.md#get_user_uploads) | **GET** /user/uploads | List previous uploads
*Web3Storage::Web3StorageHTTPAPIApi* | [**head_car_cid**](docs/Web3StorageHTTPAPIApi.md#head_car_cid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
*Web3Storage::Web3StorageHTTPAPIApi* | [**post_car**](docs/Web3StorageHTTPAPIApi.md#post_car) | **POST** /car | Upload a CAR
*Web3Storage::Web3StorageHTTPAPIApi* | [**post_pins**](docs/Web3StorageHTTPAPIApi.md#post_pins) | **POST** /pins | Add pin object
*Web3Storage::Web3StorageHTTPAPIApi* | [**post_pins_requestid**](docs/Web3StorageHTTPAPIApi.md#post_pins_requestid) | **POST** /pins/{requestid} | Replace pin object
*Web3Storage::Web3StorageHTTPAPIApi* | [**post_upload**](docs/Web3StorageHTTPAPIApi.md#post_upload) | **POST** /upload | Upload and store one or more files


## Documentation for Models

 - [Web3Storage::Deal](docs/Deal.md)
 - [Web3Storage::ErrorResponse](docs/ErrorResponse.md)
 - [Web3Storage::Failure](docs/Failure.md)
 - [Web3Storage::FailureError](docs/FailureError.md)
 - [Web3Storage::ForbiddenErrorResponse](docs/ForbiddenErrorResponse.md)
 - [Web3Storage::PSAPin](docs/PSAPin.md)
 - [Web3Storage::Pin](docs/Pin.md)
 - [Web3Storage::PinResults](docs/PinResults.md)
 - [Web3Storage::PinStatus](docs/PinStatus.md)
 - [Web3Storage::PinStatusPin](docs/PinStatusPin.md)
 - [Web3Storage::Status](docs/Status.md)
 - [Web3Storage::TextMatchingStrategy](docs/TextMatchingStrategy.md)
 - [Web3Storage::UnauthorizedErrorResponse](docs/UnauthorizedErrorResponse.md)
 - [Web3Storage::UploadResponse](docs/UploadResponse.md)


## Documentation for Authorization


### bearerAuth

- **Type**: Bearer authentication (JWT)

