using System;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StreamReader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Streamr!");

            var _loginAPI = new LoginApi();
            string _username = Environment.GetEnvironmentVariable("STREAMR_USERNAME");
            string _password = Environment.GetEnvironmentVariable("STREAMR_PASSWORD");
            var body = new UsernamePassword(_username, _password);

            // Log in with password verification
            SessionToken _sessionToken = _loginAPI.LoginPasswordPost(body);
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer " + _sessionToken.Token);
            var _streamsAPI = new StreamsApi();
            Console.WriteLine("Login Ok: " + _sessionToken);

            // Just hard-coding my test stream id for now (could have parsed it from API calls of course):
            string _testStreamId = "uTsGe6-gRbua5Ln45KGnag";

            long lastTimestamp = 0;
            while (true)
            {
                // let's ask for the most recent packet:
                ApiResponse<object> apiResponse = _streamsAPI.StreamsIdDataPartitionsPartitionLastGetWithHttpInfo(_testStreamId, 0, 1);
                string _rawJsonData = (string)apiResponse.Data;
                List<MyStreamrData> myStreamrData = JsonConvert.DeserializeObject<List<MyStreamrData>>(_rawJsonData);
                // only write the packet if we got data and also only if it's a new one:
                if (myStreamrData.Count > 0)
                {
                    long thisTimestamp = myStreamrData[0].timestamp;
                    if (thisTimestamp != lastTimestamp)
                    {
                        Console.WriteLine("Received Packet: Timestamp=" + thisTimestamp + ", IntData=" + myStreamrData[0].content.IntData + ", StringData=" + myStreamrData[0].content.StringData);
                    }
                    lastTimestamp = thisTimestamp;
                }
            }

        }
    }

    // lets define a class to map to our API result, to make conversion from JSON easier:
    class MyStreamrData
    {
        public string streamId { get; set; }
        public int streamPartition { get; set; }
        public long timestamp { get; set; }
        public int sequenceNumber { get; set; }
        public string publisherId { get; set; }
        public string msgChainId { get; set; }
        public int messageType { get; set; }
        public int contentType { get; set; }
        public string groupKeyId { get; set; }
        public JsonBodyContentType content { get; set; }
        public int signatureType { get; set; }
        public string signature { get; set; }
    }

    class JsonBodyContentType
    {
        public int IntData { get; set; }
        public string StringData { get; set; }
    }
}
