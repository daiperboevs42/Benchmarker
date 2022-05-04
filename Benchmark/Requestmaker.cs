using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class Requestmaker
    {
        private static HttpClient client;
        public Requestmaker()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://34.142.65.39:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        static void ShowResponse(string placeholder)
        {
            Console.WriteLine(placeholder);
        }

        public static async Task<string> GetResponse()
        {
            string placeholder = null;
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                placeholder = await response.Content.ReadAsStringAsync();
            }
            ShowResponse(placeholder);
            return placeholder;
        }

    }
}
