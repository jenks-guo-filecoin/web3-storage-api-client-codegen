"""
    Web3.Storage API

    This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits.   # noqa: E501

    The version of the OpenAPI document: 1.0
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import Web3Storage
from Web3Storage.model.failure_error import FailureError
globals()['FailureError'] = FailureError
from Web3Storage.model.failure import Failure


class TestFailure(unittest.TestCase):
    """Failure unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testFailure(self):
        """Test Failure"""
        # FIXME: construct object with mandatory attributes with example values
        # model = Failure()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
