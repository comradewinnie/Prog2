using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static async Task Main(string[] args)
    {
        var apiUri = "http://universities.hipolabs.com/search?country=latvia";

        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetAsync(apiUri);
            var responseBody = await response.Content.ReadAsStringAsync();

            List<University>? universities = JsonSerializer.Deserialize<List<University>>(responseBody);

            foreach (var university in universities.OrderBy(x => x.Name))
            {
                Console.WriteLine(university.Name);
            }
        }
    }

    public class University
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

    }
}