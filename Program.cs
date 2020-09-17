using System;
using ServiceStack.Redis;
using System.Text;

namespace CloudAcademy.Redis
{
    class Program
    {
        private static void WriteData()
        {
            using (IRedisClient client = new RedisClient())
            {
                System.Console.WriteLine("writing...");
                client.Set("cloudacademy:author1", Encoding.UTF8.GetBytes("Andrew Larkin"));
                client.Set("cloudacademy:author2", Encoding.UTF8.GetBytes("Jeremy Cook"));
                client.Set("cloudacademy:author3", Encoding.UTF8.GetBytes("Stuart Scott"));
                client.Set("cloudacademy:author4", Encoding.UTF8.GetBytes("Logan Rakai"));
            }
        }

        private static void ReadData()
        {
            using (IRedisClient client = new RedisClient())
            {
                System.Console.WriteLine("reading...");
                var author1 = client.Get<String>("cloudacademy:author1");
                var author2 = client.Get<String>("cloudacademy:author2");
                var author3 = client.Get<String>("cloudacademy:author3");
                var author4 = client.Get<String>("cloudacademy:author4");

                System.Console.WriteLine(author1);
                System.Console.WriteLine(author2);
                System.Console.WriteLine(author3);
                System.Console.WriteLine(author4);
            }
        }

        static void Main(string[] args)
        {
            WriteData();
            ReadData();
        }
    }
}