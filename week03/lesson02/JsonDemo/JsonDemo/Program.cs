using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = Task.Run(CallApi).Result;

            foreach (var item in posts)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"UserId: {item.UserId}");
                Console.WriteLine($"Título: {item.Title}");
                Console.WriteLine($"Cuerpo: {item.Body}");
            }

            Console.ReadKey();
        }

        private async static Task<List<Post>> CallApi()
        {
            string data = await GetData();

            List<Post> posts = DeserializeData(data);

            return posts;
        }

        private static List<Post> DeserializeData(string data)
        {
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(data);

            return posts;
        }

        private async static Task<string> GetData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            var content = await client.GetStringAsync(url);

            return content;
        }
    }
}
