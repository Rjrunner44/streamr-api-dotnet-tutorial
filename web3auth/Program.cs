using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Util;
using System.Text;
using Nethereum.Signer;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.ABI.Encoders;

namespace ListStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Streamr!");

            var _loginAPI = new LoginApi();
            var publicAddr = "your eth address goes here";
            var privateKey = "your private key goes here";
            try
            {
                // you can get your eth account also if you wanted:
                //var account = new Account(privateKey);
                //Console.WriteLine("Our account: " + account.Address);

                // and also web3 is available if needed (we don't need it):
                //var web3 = new Web3(account, "https://mainnet.infura.io/v3/7238211010344719ad14a89db874158c");

                Challenge challenge = _loginAPI.LoginChallengeAddressPost(publicAddr);
                ChallengeResponseChallenge c = new ChallengeResponseChallenge(challenge.Id, challenge._Challenge);
                var signer1 = new EthereumMessageSigner();
                var signature = signer1.EncodeUTF8AndSign(challenge._Challenge, new EthECKey(privateKey));
                ChallengeResponse response = new ChallengeResponse(c, signature, publicAddr);

                SessionToken _sessionToken = _loginAPI.LoginResponsePost(response);
                Console.WriteLine("Login Ok: " + _sessionToken);

                // Read the available streams:
                Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer " + _sessionToken.Token);
                Console.WriteLine("Reading Available Streams...");

                var _streamsAPI = new StreamsApi();
                //var name = name_example;  // string | Only return streams that exactly match the given name. (optional) 
                //var uiChannel = true;  // bool? | Filter by whether this stream is an UI channel or not. UI channels are streams used to push updates to visualisation widgets. For the typical list of streams, set this to false. (optional)  (default to false)
                //var noConfig = true;  // bool? | Remove config object from JSON response. (optional)  (default to false)
                //var search = search_example;  // string | Filter by search term in name or description (optional) 
                //var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
                //var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
                //var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
                //var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
                //var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
                //var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
                //var operation = operation_example;  // string | Filter results by Permission (access level) (optional)  (default to stream_get)

                try
                {
                    // List streams
                    List<Stream> result = _streamsAPI.StreamsGet(); // name, uiChannel, noConfig, search, sortBy, order, max, offset, grantedAccess, publicAccess, operation);
                    foreach (Stream s in result)
                    {
                        Console.WriteLine("Stream: Name='" + s.Name + "', Id='" + s.Id + "'");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when calling StreamsApi.StreamsGet: " + e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling LoginApi.LoginPasswordPost: " + e.Message);
            }
        }
    }
}
