using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingltonDesignPat
{
    internal class Singleton2
    {
        private static Singleton2 _instance;

        private static readonly object _instanceLock = new object();

        private Singleton2() { }

        public static Singleton2 getInstance()
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new Singleton2();
                }
            }
            return _instance;
        }
    }
}
