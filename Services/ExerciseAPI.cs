using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace gym_assistant;

public class ExerciseAPIService
{
    public async Task<List<Exercise>> GetExerciseAsync(string? exercise)
    {
        HttpClient _httpClient = new HttpClient();

        string apiUrl = $"https://api.api-ninjas.com/v1/exercises?name={exercise}";

        var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

        request.Headers.Add("X-Api-Key", "VKGe2sIZjSOB2ifXsKVfsyk8oHc1frzz90wyCWyn");

        HttpResponseMessage response = await _httpClient.SendAsync(request);

        // if (response.StatusCode != HttpStatusCode.OK)
        // {
        //     throw new HttpRequestException($"The server responded with an status code of: {response.StatusCode}");
        // }

        string responseString = await response.Content.ReadAsStringAsync();

        var exercises = JsonSerializer.Deserialize<List<Exercise>>(responseString);

        Console.WriteLine(exercises);

        return exercises!;

        // response.EnsureSuccessStatusCode();
        // var json = await response.Content.ReadAsStringAsync();

        // var exercises = JsonSerializer.Deserialize<List<Exercise>>(json);

        // return exercises ?? new List<ExerciseRoot>();
    }
    public class Exercise
    {
        public string? name { get; set; }
        public string? type { get; set; }
        public string? muscule { get; set; }
        public string? difficulty { get; set; }
        public string? instructions { get; set; }
        public List<string>? equipments { get; set; }
        public string? safety_info { get; set; }
    }

}
