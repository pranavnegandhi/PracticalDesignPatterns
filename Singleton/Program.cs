using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Acquire the instance and cache it in a local variable
            // to use it like any other instance.
            var s1 = SingleThreadedLazySingleton.Instance;
            var result = s1.Operation();
            Console.WriteLine(result);

            // This singleton can be accessed across multiple threads.
            var s2 = MultithreadedLazySingleton.Instance;
            result = s2.Operation();
            Console.WriteLine(result);

            // This singleton can be accessed across threads without a lock.
            var s3 = LockFreeMultithreadedLazySingleton.Instance;
            result = s3.Operation();
            Console.WriteLine(result);
        }
    }
}