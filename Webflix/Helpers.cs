namespace Webflix
{
    public static class Helpers
    {
        public static string HttpToHttps(string url)
        {
            return url.Replace("http://", "https://");
        }
    }
}
