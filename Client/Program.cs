namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();

            var response = httpClient.GetAsync("https://github.com").Result;

            var context = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(context);
        }
    }
}
