namespace Logger
{
    public sealed class Log
    {
        private static Log _instance;
        private static readonly object _lockObject = new object();

        private Log()
        {
        }

        public static Log Instance 
        {
            get
            {
                if( _instance == null)
                {
                    lock( _lockObject)
                    {
                        _instance = new Log();
                    }
                }
                return _instance;
            }
        }
    }
}
