using Flurl.Http;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RainForestQAChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string id = "";
            try
            {
                do
                {
                    var url = "https://letsrevolutionizetesting.com/challenge.json?";


                    var client = new RestClient();

                    var request = new RestRequest(string.Concat(url, id), Method.GET);
                    if (string.IsNullOrEmpty(id) == false)
                    {
                        request.AddQueryParameter("id", id);
                    }

                    var content = client.Execute(request).Content;

                    var jsonPayload = JsonConvert.DeserializeObject<JsonPayload>(content);

                    flag = int.TryParse(jsonPayload.Follow.Replace("https://letsrevolutionizetesting.com/challenge?id=", ""), out int n);

                    if (flag)
                    {
                        id = n.ToString();

                        Console.WriteLine("Next request is  with Id {0}", id);
                    }


                } while (flag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Final Id is ", id);

        }


    }

    public class JsonPayload
    {
        public string Follow { get; set; }
    }

}
