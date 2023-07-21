using DesignPatternsTemplates;
using System.Diagnostics;

namespace SingletonTemplate.Console
{
    public static class Singleton
    {
        public static void print()
        {
            UserSingleton singletonObject1 = UserSingleton.getInstance();
            UserSingleton singletonObject2 = UserSingleton.getInstance();
            Debug.WriteLine(singletonObject1 == singletonObject2);
            Debug.WriteLine(singletonObject1.GetHashCode());
            Debug.WriteLine(singletonObject2.GetHashCode());
            Debug.WriteLine("");

            singletonObject1.PrintUsers();

        }
    }
}
