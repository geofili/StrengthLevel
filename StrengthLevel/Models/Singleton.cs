using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrengthLevel.Models
{
    public class Singleton
    {

        private static Singleton instance = null;
        private static readonly Object padlock = new Object();

        Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        public static Singleton Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public static void Print()
        {
            Console.WriteLine("Hello from Singleton instance.");
        }

    }
}