namespace Singleton
{
    public class LockFreeMultithreadedLazySingleton
    {
        private static readonly LockFreeMultithreadedLazySingleton _instance = new LockFreeMultithreadedLazySingleton();

        static LockFreeMultithreadedLazySingleton()
        {
        }

        private LockFreeMultithreadedLazySingleton()
        {
        }

        public string Operation()
        {
            return $"Executing {nameof(LockFreeMultithreadedLazySingleton)}.{nameof(Operation)}()";
        }

        public static LockFreeMultithreadedLazySingleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}