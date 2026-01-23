using RestSharp;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var client = new RestClient("");
        var request = new RestRequest("/sessions", Method.Post);


        var response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            Console.WriteLine(response.Content);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode} - {response.ErrorMessage}");
        }
    }
}
