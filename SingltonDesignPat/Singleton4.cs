using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SingltonDesignPat
{
    internal class Singleton4
    {
        private static readonly Lazy<Singleton4> _instance = new Lazy<Singleton4>(()=>new Singleton4());

        private Singleton4() { }

        public static Singleton4 Instance =>_instance.Value;
        

    }

}
