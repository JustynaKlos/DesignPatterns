using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    public class Singleton <T> where T :class, new()
    {
        private static T instance;
        protected Singleton() { }
        private static readonly object padLock = new object();
        public static int numberOfObject = 0;
      
        public static T Create()
        {
            if (instance == null)
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                        numberOfObject++;
                    }
                }
            }
            return instance;
        }
    }
}
