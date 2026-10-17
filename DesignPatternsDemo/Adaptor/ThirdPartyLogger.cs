namespace DesignPatternsDemo.Adaptor
{
    internal class ThirdPartyLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"ThirdPartyLogger: {message}");
        }
    }
}
