namespace Logger
{
    public sealed class Logger
    {
        private Logger()
        {
        }

        public static Logger Instance { get; } = new Logger();
    }
}
