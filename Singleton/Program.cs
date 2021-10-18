using System;

namespace Singleton
{


    class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
    class Program
    {
        //Singleton is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.
        static void Main(string[] args)
        {
           Singleton s1=Singleton.Instance();
            Singleton s2=Singleton.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
