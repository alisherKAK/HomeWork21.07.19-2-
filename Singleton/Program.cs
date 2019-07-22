using System;

namespace Singleton
{
    public class Singleton
    {
        private Singleton(){}
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public static void SomeLogin()
        {
            Console.WriteLine("Hello! I'm Singleton and I'm only one in this program");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if(s1 == s2)
            {
                Console.WriteLine("Singleton works correctly");
            }
            else
            {
                Console.WriteLine("Singleton works incorrectly");
            }
        }
    }
}
