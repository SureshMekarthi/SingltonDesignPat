using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingltonDesignPat
{
    internal class Singlton3
    {

        private static Singlton3 _instance = new Singlton3();

        private Singlton3() { }

        public static Singlton3 GetInstance => _instance;
    }
}
