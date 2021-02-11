namespace Singleton
{
    public class MultithreadedLazySingleton
    {
        private static MultithreadedLazySingleton _instance;

        private static readonly object padlock = new { };

        private MultithreadedLazySingleton()
        {
            // Initialise the collection objects
        }

        public string Operation()
        {
            return $"Executing {nameof(MultithreadedLazySingleton)}.{nameof(Operation)}()";
        }

        public static MultithreadedLazySingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (null == _instance)
                    {
                        _instance = new MultithreadedLazySingleton();
                    }

                    return _instance;
                }
            }
        }
    }
}