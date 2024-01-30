namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(5);
            
            var response = httpClient.GetAsync("https://github.com").Result;

            var context = response.Content.ReadAsStringAsync().Result;


            
        }
    }
}
