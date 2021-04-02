using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using StackExchange.Redis;
using System.Threading.Tasks;
using System.Configuration;

namespace RedisCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Request("Request an object", new object());
            Request("Request a computation", "y = x + x; x = 5");
            Request("Request a computation", "y = x + x; x = 5"); // again
            Request("Request a file content", "/etc/passwd");
            Request("Unique request " + Guid.NewGuid().ToString(), "/etc/passwd");


            lazyConnection.Value.Dispose();

            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            string cacheConnection = ConfigurationManager.ConnectionStrings["RedisCacheString"].ConnectionString;
            return ConnectionMultiplexer.Connect(cacheConnection);
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
        private static void Request(string command, object parameters)
        {
            IDatabase cache = Connection.GetDatabase();

            var responseFactory = new Func<object, string>((object _) => "Dummy response");
            string response;
            bool wasCached;

            if (wasCached = cache.KeyExists(command))
            {
                response = cache.StringGet(command);
            }
            else
            {
                response = responseFactory(parameters);
                cache.StringSet(command, response);
            }

            long counter = cache.StringIncrement($"{command} counter", 1);

            Console.WriteLine($"Command: \"{command}\" #{counter}, Response: \"{response}\" ({(wasCached ? "cached" : "not cached")})");
        }
    }
}
