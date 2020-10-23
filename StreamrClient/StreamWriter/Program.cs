using System;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace StreamWriter
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

            for (int i = 1; i <= 1000; i++)
            {
                var rand = new Random().Next();
                var _data = new { IntData = rand, StringData = "test" + rand };
                string _jsonData = System.Text.Json.JsonSerializer.Serialize(_data);
                Console.WriteLine("Putting Data: " + _jsonData + " to stream id: " + _testStreamId);
                _streamsAPI.StreamsIdDataPost(_testStreamId, _jsonData); //, ttl, pkey, signatureType, address, signature);
                Console.WriteLine("Put Successful");
                await Task.Delay(5000);
            }
        }
    }
}
