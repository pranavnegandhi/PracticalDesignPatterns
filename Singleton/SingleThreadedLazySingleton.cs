using System.Collections.Generic;
using System.Data;

namespace Singleton
{
    public sealed class SingleThreadedLazySingleton
    {
        private static SingleThreadedLazySingleton _instance;

        private ISet<IDbConnection> _released;

        private ISet<IDbConnection> _acquired;

        private SingleThreadedLazySingleton()
        {
            // Initialise the collection objects
        }

        public string Operation()
        {
            return $"Executing {nameof(SingleThreadedLazySingleton)}.{nameof(Operation)}()";
        }

        public static SingleThreadedLazySingleton Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new SingleThreadedLazySingleton();
                }

                return _instance;
            }
        }
    }
}