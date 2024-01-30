using System.Net;
using System.Text;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var httpLestener = new HttpListener();

            httpLestener.Prefixes.Add("http://localhost:50002/");
            //httpLestener.Prefixes.Add("http://127.0.0.1:50003/");

            var text = "test message";
            var bytes = Encoding.UTF8.GetBytes(text);


            httpLestener.Start();
            var requestContext = httpLestener.GetContext();

            requestContext.Response.StatusCode = 200;
            var stream = requestContext.Response.OutputStream;
            stream.Write(bytes, 0, bytes.Length);


            requestContext.Response.Close();
            httpLestener.Stop();
            httpLestener.Close();

            Console.WriteLine(HttpListener.IsSupported);
        }
    }
}
