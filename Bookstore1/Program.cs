using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await CallApiAndDisplayData();
    }

    static async Task CallApiAndDisplayData()
    {
        
        string APIkey = "AIzaSyCwZbNRhrSTIUxB53xAxUcHkxeppxC7fH0";
        string url = "";  // Replace with the actual API endpoint URL

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();  // Throw an exception if the request was unsuccessful

                string responseBody = await response.Content.ReadAsStringAsync();
                // Process the response body as needed and display it to the user
                Console.WriteLine(responseBody);  // Just an example, you can format and display the data in any desired way
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
