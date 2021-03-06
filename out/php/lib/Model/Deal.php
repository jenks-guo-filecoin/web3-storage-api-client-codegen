<?php
/**
 * Deal
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits.
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.2.1
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * Deal Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class Deal implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'Deal';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'deal_id' => 'float',
        'storage_provider' => 'string',
        'status' => 'string',
        'piece_cid' => 'string',
        'data_cid' => 'string',
        'data_model_selector' => 'string',
        'activation' => 'string',
        'created' => 'string',
        'updated' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'deal_id' => null,
        'storage_provider' => null,
        'status' => null,
        'piece_cid' => null,
        'data_cid' => null,
        'data_model_selector' => null,
        'activation' => null,
        'created' => null,
        'updated' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'deal_id' => 'dealId',
        'storage_provider' => 'storageProvider',
        'status' => 'status',
        'piece_cid' => 'pieceCid',
        'data_cid' => 'dataCid',
        'data_model_selector' => 'dataModelSelector',
        'activation' => 'activation',
        'created' => 'created',
        'updated' => 'updated'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'deal_id' => 'setDealId',
        'storage_provider' => 'setStorageProvider',
        'status' => 'setStatus',
        'piece_cid' => 'setPieceCid',
        'data_cid' => 'setDataCid',
        'data_model_selector' => 'setDataModelSelector',
        'activation' => 'setActivation',
        'created' => 'setCreated',
        'updated' => 'setUpdated'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'deal_id' => 'getDealId',
        'storage_provider' => 'getStorageProvider',
        'status' => 'getStatus',
        'piece_cid' => 'getPieceCid',
        'data_cid' => 'getDataCid',
        'data_model_selector' => 'getDataModelSelector',
        'activation' => 'getActivation',
        'created' => 'getCreated',
        'updated' => 'getUpdated'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }

    const STATUS_QUEUED = 'Queued';
    const STATUS_PUBLISHED = 'Published';
    const STATUS_ACTIVE = 'Active';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getStatusAllowableValues()
    {
        return [
            self::STATUS_QUEUED,
            self::STATUS_PUBLISHED,
            self::STATUS_ACTIVE,
        ];
    }

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['deal_id'] = $data['deal_id'] ?? null;
        $this->container['storage_provider'] = $data['storage_provider'] ?? null;
        $this->container['status'] = $data['status'] ?? null;
        $this->container['piece_cid'] = $data['piece_cid'] ?? null;
        $this->container['data_cid'] = $data['data_cid'] ?? null;
        $this->container['data_model_selector'] = $data['data_model_selector'] ?? null;
        $this->container['activation'] = $data['activation'] ?? null;
        $this->container['created'] = $data['created'] ?? null;
        $this->container['updated'] = $data['updated'] ?? null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['status'] === null) {
            $invalidProperties[] = "'status' can't be null";
        }
        $allowedValues = $this->getStatusAllowableValues();
        if (!is_null($this->container['status']) && !in_array($this->container['status'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value '%s' for 'status', must be one of '%s'",
                $this->container['status'],
                implode("', '", $allowedValues)
            );
        }

        if ($this->container['created'] === null) {
            $invalidProperties[] = "'created' can't be null";
        }
        if ($this->container['updated'] === null) {
            $invalidProperties[] = "'updated' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets deal_id
     *
     * @return float|null
     */
    public function getDealId()
    {
        return $this->container['deal_id'];
    }

    /**
     * Sets deal_id
     *
     * @param float|null $deal_id On-chain ID of the deal.
     *
     * @return self
     */
    public function setDealId($deal_id)
    {
        $this->container['deal_id'] = $deal_id;

        return $this;
    }

    /**
     * Gets storage_provider
     *
     * @return string|null
     */
    public function getStorageProvider()
    {
        return $this->container['storage_provider'];
    }

    /**
     * Sets storage_provider
     *
     * @param string|null $storage_provider Address of the provider storing this data.
     *
     * @return self
     */
    public function setStorageProvider($storage_provider)
    {
        $this->container['storage_provider'] = $storage_provider;

        return $this;
    }

    /**
     * Gets status
     *
     * @return string
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     *
     * @param string $status Current deal status.
     *
     * @return self
     */
    public function setStatus($status)
    {
        $allowedValues = $this->getStatusAllowableValues();
        if (!in_array($status, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value '%s' for 'status', must be one of '%s'",
                    $status,
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets piece_cid
     *
     * @return string|null
     */
    public function getPieceCid()
    {
        return $this->container['piece_cid'];
    }

    /**
     * Sets piece_cid
     *
     * @param string|null $piece_cid Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal.
     *
     * @return self
     */
    public function setPieceCid($piece_cid)
    {
        $this->container['piece_cid'] = $piece_cid;

        return $this;
    }

    /**
     * Gets data_cid
     *
     * @return string|null
     */
    public function getDataCid()
    {
        return $this->container['data_cid'];
    }

    /**
     * Sets data_cid
     *
     * @param string|null $data_cid CID of the data aggregated in this deal.
     *
     * @return self
     */
    public function setDataCid($data_cid)
    {
        $this->container['data_cid'] = $data_cid;

        return $this;
    }

    /**
     * Gets data_model_selector
     *
     * @return string|null
     */
    public function getDataModelSelector()
    {
        return $this->container['data_model_selector'];
    }

    /**
     * Sets data_model_selector
     *
     * @param string|null $data_model_selector Selector for extracting stored data from the aggregated data root.
     *
     * @return self
     */
    public function setDataModelSelector($data_model_selector)
    {
        $this->container['data_model_selector'] = $data_model_selector;

        return $this;
    }

    /**
     * Gets activation
     *
     * @return string|null
     */
    public function getActivation()
    {
        return $this->container['activation'];
    }

    /**
     * Sets activation
     *
     * @param string|null $activation Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
     *
     * @return self
     */
    public function setActivation($activation)
    {
        $this->container['activation'] = $activation;

        return $this;
    }

    /**
     * Gets created
     *
     * @return string
     */
    public function getCreated()
    {
        return $this->container['created'];
    }

    /**
     * Sets created
     *
     * @param string $created Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
     *
     * @return self
     */
    public function setCreated($created)
    {
        $this->container['created'] = $created;

        return $this;
    }

    /**
     * Gets updated
     *
     * @return string
     */
    public function getUpdated()
    {
        return $this->container['updated'];
    }

    /**
     * Sets updated
     *
     * @param string $updated Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
     *
     * @return self
     */
    public function setUpdated($updated)
    {
        $this->container['updated'] = $updated;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


