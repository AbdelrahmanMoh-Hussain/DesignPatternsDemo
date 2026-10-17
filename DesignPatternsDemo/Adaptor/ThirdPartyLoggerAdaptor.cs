namespace DesignPatternsDemo.Adaptor
{
    internal class ThirdPartyLoggerAdaptor : ILogger
    {
        private readonly ThirdPartyLogger _thirdPartyLogger;
        public ThirdPartyLoggerAdaptor(ThirdPartyLogger thirdPartyLogger)
        {
            _thirdPartyLogger = thirdPartyLogger;
        }

        public void Log(string message)
        {
            _thirdPartyLogger.LogMessage(message);
        }
    }
}
